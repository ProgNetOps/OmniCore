namespace OmniCore.Domain.Entities.ClientManagement;

/// <summary>
/// Class that represents the current status of the service - Up, Fluctuating, Slow, Down, Degraded etc
/// </summary>
public class LinkStatus
{
    public Guid LinkStatusId { get; set; }
    public string? Name { get; set; }
}
