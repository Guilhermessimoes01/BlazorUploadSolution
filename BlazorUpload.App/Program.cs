using BlazorUpload.App;
using BlazorUpload.App.Services;
using BlazorUpload.App.Services.Entity;
using BlazorUpload.App.Services.Interface;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAuthService, AuthService>();


builder.Services.AddHttpClient(nameof(FileService), client => client.BaseAddress = new Uri("http://localhost:5159"));
builder.Services.AddScoped<FileService>();

await builder.Build().RunAsync();
