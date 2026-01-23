using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VedaVerk.Client;
using VedaVerk.Client.Services.Implementations;
using VedaVerk.Client.Services.Interfaces;

namespace VedaVerk.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddAuthorizationCore();
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

			builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<IBookingService, BookingService>();

			await builder.Build().RunAsync();
        }
    }
}
    