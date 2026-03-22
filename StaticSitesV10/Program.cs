using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StaticSitesV10;
using StaticSitesV10.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ComponentManagement>();
builder.Services.AddScoped<HtmlExportService>();
builder.Services.AddScoped<CleanExportService>();
builder.Services.AddScoped<FullOfflineExportService>();

await builder.Build().RunAsync();