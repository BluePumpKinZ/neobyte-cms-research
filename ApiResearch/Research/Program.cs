// See https://aka.ms/new-console-template for more information

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Backend.Repository>();
builder.Services.AddSingleton<ControllerApi.Api>();
builder.Services.AddSingleton<MinimalApi.Api>();