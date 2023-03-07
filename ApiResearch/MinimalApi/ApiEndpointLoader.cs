using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MinimalApi;

public class ApiEndpointLoader{
    public void LoadEndpoints(WebApplication app){
        foreach (var endpoints in app.Services.GetServices<IApiEndpoints>()){
            var group = app
                .MapGroup(endpoints.Path)
                .WithTags(endpoints.GroupName);
            endpoints.RegisterApis(group);
        }
    }
}