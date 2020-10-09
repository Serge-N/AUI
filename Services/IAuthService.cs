using AUI.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
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
