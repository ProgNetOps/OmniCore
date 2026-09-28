namespace OmniCore.Domain.Entities.GeoDivision;
/// <summary>
/// Class that represents Enterprise Zonal division comprising states
/// </summary>
public class Zone
{
    public Guid ZoneId { get; set; }
    public string? ZoneName { get; set; }
    public ICollection<State>? States { get; set; }
    public Guid TechnicalRegionId { get; set; }
    public TechnicalRegion? TechnicalRegion { get; set; }
}
