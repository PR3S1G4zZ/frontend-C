using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ConsumoAPI2.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuración para producción/desarrollo
var apiBase = builder.HostEnvironment.IsProduction()
    ? "https://backend-c-production.up.railway.app"  // URL de tu API en Railway
    : "http://localhost:5216";             // URL local de tu API

// HttpClient para TU backend
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(apiBase)
});

// HttpClient para Dog API
builder.Services.AddHttpClient("DogAPI", client => 
{
    client.BaseAddress = new Uri("https://api.thedogapi.com/v1/");
    client.DefaultRequestHeaders.Add("x-api-key", "live_IO5ZjVjwigVhC3SrfgvEMNe2fB22sSL5H998b9RAtEBkXIkPfRhEDlZQuWbKAcYz");
});

await builder.Build().RunAsync();
