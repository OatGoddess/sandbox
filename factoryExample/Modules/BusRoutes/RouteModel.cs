public record RouteModel
{
  public Guid Id { get; init; } = default!;
  public string Number { get; init; } = default!;
  public string CurrentStop { get; init; } = default!;
  public List<string> Route { get; init; } = default!;
}