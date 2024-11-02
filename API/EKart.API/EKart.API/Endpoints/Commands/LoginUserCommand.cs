using EKart.Infrastructure.Models;
using EKart.Infrastructure.Repositories.Repo_Interfaces;
using MediatR;

namespace EKart.API.Endpoints.Commands
{
    public record LoginUserCommand(UserLoginModel user) : IRequest<string>
    {
    }
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IUserRepo _userRepo;
        public LoginUserHandler(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(await _userRepo.Login(request.user));
        }
    }
}
