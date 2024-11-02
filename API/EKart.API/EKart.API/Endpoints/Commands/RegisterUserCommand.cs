using EKart.Infrastructure.Models;
using EKart.Infrastructure.Repositories.Repo_Interfaces;
using MediatR;

namespace EKart.API.Endpoints.Commands
{
    public record RegisterUserCommand(UserRegisterModel user) : IRequest<bool>
    {
    }
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, bool>
    {
        private readonly IUserRepo _userRepo;
        public RegisterUserHandler(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<bool> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(await _userRepo.Register(request.user));
        }
    }
}