public interface IBusRouteProvider
{
    public RouteModel GetBusRoute(string busNumber);

    public string City { get; }
}

