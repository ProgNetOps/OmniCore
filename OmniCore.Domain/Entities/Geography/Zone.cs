namespace OmniCore.Domain.Entities.Geography;
/// <summary>
/// Class that represents Enterprise Zonal division comprising states
/// </summary>
public class Zone
{
    public int ZoneId { get; set; }
    public string? ZoneName { get; set; }
    public ICollection<State>? States { get; set; }
    public int TechnicalRegionId { get; set; }
    public TechnicalRegion? TechnicalRegion { get; set; }
}
