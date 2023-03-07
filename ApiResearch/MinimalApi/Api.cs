using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;


namespace MinimalApi;

public class Api : IApiEndpoints{
    public string GroupName => "MinimalApi";
    public string Path => "/api/minimal";
    
    public void RegisterApis(RouteGroupBuilder routes){
        routes.MapGet("test", (
        ) => Results.Ok());
    }
}