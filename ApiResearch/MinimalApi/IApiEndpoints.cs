using Microsoft.AspNetCore.Routing;

namespace MinimalApi;

public interface IApiEndpoints{
    public string GroupName { get; }
    public string Path { get; }

    public void RegisterApis (RouteGroupBuilder routes);
}