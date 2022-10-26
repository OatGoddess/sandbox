namespace factoryExample.Modules.BusRoutes.Providers;
public class PortlandProvider : IBusRouteProvider
{
    public string City => "Portland";

    public RouteModel GetBusRoute(string busNumber)
    {
        //Call Portland API here
        return new RouteModel { Id = Guid.NewGuid(), CurrentStop = "Morrison & 16th", Number = busNumber, Route = new List<string> { "Morrison & 16th", "Morrison & 12th" } };
    }
}
