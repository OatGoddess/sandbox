public class BusRouteModule : IModule
{
    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Route/{City}/{BusNumber}", (IBusRouteFactory factory, string City, string BusNumber) =>
        {
            var busRouteProvider = factory.GetBusRouteProviderByCity(City);
            return Results.Json(busRouteProvider.GetBusRoute(BusNumber));
        });
        return endpoints;
    }
}