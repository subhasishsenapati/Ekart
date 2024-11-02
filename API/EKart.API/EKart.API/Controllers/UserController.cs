using AutoMapper;
using EKart.API.DTOs.Request;
using EKart.API.Endpoints.Commands;
using EKart.Infrastructure.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKart.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO request)
        {
            var newUser = _mapper.Map<UserRegisterModel>(request);
            var response = await _mediator.Send(new RegisterUserCommand(newUser));
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            var user = _mapper.Map<UserLoginModel>(request);
            var response = await _mediator.Send(new LoginUserCommand(user));
            return Ok(response);
        }
    }
}
