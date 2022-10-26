namespace factoryExample.Modules.BusRoutes.Providers;
public class SeattleProvider : IBusRouteProvider
{
    public string City => "Seattle";

    public RouteModel GetBusRoute(string busNumber)
    {
        //Call Seattle API here
        return new RouteModel { Id = Guid.NewGuid(), CurrentStop = "Othello", Number = busNumber, Route = new List<string> { "Othello", "Columbia" } };
    }
}
