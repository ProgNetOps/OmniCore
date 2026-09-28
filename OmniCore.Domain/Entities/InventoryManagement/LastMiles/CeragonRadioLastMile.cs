using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement.LastMiles;

public class CeragonRadioLastMile: LastMile, ILastMileRadio
{
    public override LastMileType LastMileType { get; set; } = LastMileType.Ceragon;

    public (string? ODUSerialNumber, string? IDUSerialNumber,
        string? RadioManagementVLAN, string? RadioFrequency,
        string? RadioManagementIPAtPoP, string? RadioManagementIPAtClient,
        string? ManagedRadioIPGateway, string? SubnetMaskForManagementIP)
        LastMileRadioInfo(string? ODUSerialNumber, string? IDUSerialNumber,
        string? RadioManagementVLAN, string? RadioFrequency,
        string? RadioManagementIPAtPoP, string? RadioManagementIPAtClient,
        string? ManagedRadioIPGateway, string? SubnetMaskForManagementIP)
    {
        return (ODUSerialNumber, IDUSerialNumber,
        RadioManagementVLAN, RadioFrequency,
        RadioManagementIPAtPoP, RadioManagementIPAtClient,
        ManagedRadioIPGateway, SubnetMaskForManagementIP);
    }
}
