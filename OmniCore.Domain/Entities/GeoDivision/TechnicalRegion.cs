namespace OmniCore.Domain.Entities.GeoDivision;

public class TechnicalRegion
{
    public Guid TechnicalRegionId { get; set; }

    public string? RegionName { get; set; }

    public ICollection<Zone>? Zones { get; set; }
}
