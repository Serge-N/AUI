using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AUI.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using Tewr.Blazor.FileReader;
using AgrixemUI.Services;

namespace AUI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/") });
            
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

            builder.Services.AddFileReaderService(options => options.UseWasmSharedBuffer = true);

            builder.Services.AddScoped<IAuthService, AuthService>();

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddOptions();

            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }
    }
}
