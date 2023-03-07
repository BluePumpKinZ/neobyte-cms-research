// See https://aka.ms/new-console-template for more information

using MinimalApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ControllerApi.Api>();
builder.Services.AddSingleton<MinimalApi.ApiEndpointLoader>();
builder.Services.AddSingleton<IApiEndpoints,MinimalApi.Api>();

builder.Services.AddCors();

var app = builder.Build();

app.UseMinimalApi();

app.Run();
