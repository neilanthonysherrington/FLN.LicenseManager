global using FLN.LicenseManager.Shared;
using FLN.LicenseManager.Client;
using FLN.LicenseManager.Client.Services.LicenseUIService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ILicenseUIService,  LicenseUIService>();

await builder.Build().RunAsync();
