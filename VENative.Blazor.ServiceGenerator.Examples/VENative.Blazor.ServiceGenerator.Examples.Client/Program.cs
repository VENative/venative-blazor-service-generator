using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VENative.Blazor.ServiceGenerator.Extensions.BlazorWebAssembly;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddGeneratedServices(typeof(VENative.Blazor.ServiceGenerator.Examples.Client._Imports).Assembly);

await builder.Build().RunAsync();