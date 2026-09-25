using System.ComponentModel.DataAnnotations;

namespace OmniCore.Domain.Entities;

public class TechnicalRegion
{
    public int Id { get; set; }

    public string RegionName { get; set; } = string.Empty;

    public ICollection<Zone>? Zones { get; set; }
}
