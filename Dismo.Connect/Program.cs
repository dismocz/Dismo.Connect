using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazm.Bluetooth;
using Dismo.Connect.Application;
using MudBlazor.Services;

namespace Dismo.Connect
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMudServices();

            builder.Services.AddBlazmBluetooth();

            builder.Services.AddSingleton<UriMaker>();

            var host = builder.Build();

            var uriMaker = host.Services.GetRequiredService<UriMaker>();

            await uriMaker.InitializeAsync();

            await host.RunAsync();
        }
    }
}
