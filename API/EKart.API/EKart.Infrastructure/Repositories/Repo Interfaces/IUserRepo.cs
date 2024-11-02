using EKart.Infrastructure.Models;

namespace EKart.Infrastructure.Repositories.Repo_Interfaces
{
    public interface IUserRepo
    {
        Task<bool> Register(UserRegisterModel request);
        Task<string> Login(UserLoginModel request);
    }
}
