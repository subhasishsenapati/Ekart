using AutoMapper;
using EKart.Core.Entities;
using EKart.Infrastructure.Models;
using EKart.Infrastructure.Repositories.Repo_Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EKart.Infrastructure.Repositories.Repo_Classes
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public UserRepo(AppDbContext dbContext, 
                        IMapper mapper, UserManager<IdentityUser> userManager,
                        RoleManager<IdentityRole> roleManager,
                        IConfiguration configuration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public async Task<bool> Register(UserRegisterModel request)
        {
            var newUser = _mapper.Map<User>(request);
            var userByEmail = await _userManager.FindByEmailAsync(newUser.Email);
            var userByUsername = await _userManager.FindByNameAsync(newUser.UserName);
            if (userByEmail is not null || userByUsername is not null)
            {
                throw new ArgumentException($"User with email {newUser.Email} or username {newUser.UserName} already exists.");
            }

            User user = new()
            {
                Email = newUser.Email,
                UserName = newUser.UserName,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if(request.IsSeller == true)
            {
                await _userManager.AddToRoleAsync(user, "Seller");
            }
            else
            {
                await _userManager.AddToRoleAsync(user, "Buyer");
            }
            if (!result.Succeeded)
            {
                throw new ArgumentException($"Unable to register user {request.UserName} errors: {GetErrorsText(result.Errors)}");
            }
            return true;
        }
        public async Task<string> Login(UserLoginModel request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user is null)
            {
                user = await _userManager.FindByEmailAsync(request.UserName);
            }
            if (user is null || !await _userManager.CheckPasswordAsync(user, request.Password))
            {
                throw new ArgumentException($"Unable to authenticate user {request.UserName}");
            }
            var authClaims = new List<Claim>
            {
                new(ClaimTypes.Name, user.UserName),
                new(ClaimTypes.Email, user.Email),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            var token = GetToken(authClaims);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private JwtSecurityToken GetToken(IEnumerable<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

            return token;
        }

        private string GetErrorsText(IEnumerable<IdentityError> errors)
        {
            return string.Join(", ", errors.Select(error => error.Description).ToArray());
        }    
    }
}
