using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AI_SDLC_Platform.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    //builder.HostEnvironment.BaseAddress adds port 5000 to remove it override the port with 3000
    BaseAddress = new Uri("http://localhost:3000") // No trailing slash
});

await builder.Build().RunAsync();
