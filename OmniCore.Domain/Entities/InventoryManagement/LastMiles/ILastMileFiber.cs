namespace OmniCore.Domain.Entities.InventoryManagement.LastMiles;

public interface ILastMileFiber
{
    bool IsMediaConverterAtPoP { get; set; }
    bool IsMediaConverterAtClient { get; set; }
    bool IsSwitchDeployedAtClientlocation { get; set; }
}
