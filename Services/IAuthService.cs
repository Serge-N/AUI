using AUI.Shared;
using AUI.Shared.Classes.User;
using System.Threading.Tasks;

namespace AUI.Services
{
    public interface IAuthService
    {
            Task<LoginResult> Login(LoginModel loginModel);
            Task Logout();
            Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
