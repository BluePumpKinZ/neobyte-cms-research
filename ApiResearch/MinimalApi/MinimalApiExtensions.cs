using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MinimalApi;

public static class MinimalApiExtensions{
    public static WebApplication UseMinimalApi(this WebApplication app){
        
        // Load all endpoints
        var endpointLoader = app.Services.GetRequiredService<ApiEndpointLoader>();
        endpointLoader.LoadEndpoints(app);
        
        app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
        );

        return app;
    }
}