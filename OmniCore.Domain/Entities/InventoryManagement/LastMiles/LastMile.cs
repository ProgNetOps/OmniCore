using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement.LastMiles;

public abstract class LastMile
{
    public abstract LastMileType LastMileType { get; set; }
}
