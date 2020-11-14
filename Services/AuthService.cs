
using AUI.Services;
using AUI.Shared;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AgrixemUI.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {

            RegisterResult register = null;

            var result = await _httpClient.PostAsJsonAsync("accounts", registerModel);
            if (result.IsSuccessStatusCode)
            {
                register = JsonConvert.DeserializeObject<RegisterResult>(result.Content.ReadAsStringAsync().Result);
                return register;
            }
            else
            {
                return register;
            }
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            Debug.WriteLine($"\n\n\n\nWas here...\n\n\n\n\n");
            LoginResult parsedResult = null;
          
            var result = await _httpClient.PostAsJsonAsync("api/Login/", loginModel);
         

            if (result.IsSuccessStatusCode)
            {
                parsedResult  = JsonConvert.DeserializeObject<LoginResult>(result.Content.ReadAsStringAsync().Result);

                await _localStorage.SetItemAsync("authToken", parsedResult.Token);

                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(parsedResult.Token);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", parsedResult.Token);

                return parsedResult;
            }
            else
            {
                return parsedResult;
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
        
    

    }
}
