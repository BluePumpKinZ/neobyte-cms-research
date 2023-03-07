// See https://aka.ms/new-console-template for more information

using MinimalApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ControllerApi.Api>();
builder.Services.AddSingleton<MinimalApi.ApiEndpointLoader>();
builder.Services.AddSingleton<IApiEndpoints,MinimalApi.Api>();
builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

var endpointLoader = app.Services.GetRequiredService<ApiEndpointLoader>();
endpointLoader.LoadEndpoints(app);
        
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.MapControllers();

app.Run();
