using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Radzen;
using Howler.Blazor;
using Howler.Blazor.Components;
using UnmaskedApp.Client.Code.Events;

namespace UnmaskedApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //builder.Services
            //  .AddBlazorise(options =>
            //  {
            //      options.ChangeTextOnKeyPress = true;
            //  })
            //  .AddBootstrapProviders()
            //  .AddFontAwesomeIcons();

            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<MouseClickHandler>();
            builder.Services.AddScoped<IHowl, Howl>();
            builder.Services.AddScoped<IHowlGlobal, HowlGlobal>();

            var host = builder.Build();

            //host.Services.UseBootstrapProviders().UseFontAwesomeIcons();

            await host.RunAsync();
        }
    }
}
