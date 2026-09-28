using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement.LastMiles;

public class FiberLastMile: LastMile, ILastMileFiber
{
    public override LastMileType LastMileType { get; set; } = LastMileType.Fiber;
    public bool IsMediaConverterAtPoP { get; set; }
    public bool IsMediaConverterAtClient { get; set; }
    public bool IsSwitchDeployedAtClientlocation { get; set; }
}
