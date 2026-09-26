namespace OmniCore.Domain.Entities.CircuitManagement;

/// <summary>
/// Class that represents the current status of the service - Up, Fluctuating, Slow, Down, Degraded etc
/// </summary>
public class LinkStatus
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
