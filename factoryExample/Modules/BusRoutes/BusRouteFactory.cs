using System.Collections.Immutable;

public class BusRouteFactory : IBusRouteFactory
{
    private readonly IReadOnlyDictionary<string, IBusRouteProvider> _busRouteProviders;

    public BusRouteFactory()
    {
        //Get providers using reflection and store in immutable dictionary
        var busRouteProviderType = typeof(IBusRouteProvider);
        _busRouteProviders = busRouteProviderType.Assembly.ExportedTypes
            .Where(x => busRouteProviderType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            .Select(x =>
            {
                return Activator.CreateInstance(x);
            })
            .Cast<IBusRouteProvider>()
            .ToImmutableDictionary(x => x.City, x => x);
    }

    public IBusRouteProvider GetBusRouteProviderByCity(string city)
    {
        var provider = _busRouteProviders.GetValueOrDefault(city);

        if (provider is null)
        {
            throw new Exception("Procedure Not Found");
        }

        return provider;
    }
}
