namespace OmniCore.Domain.Entities.InventoryManagement.LastMiles;
/// <summary>
/// An interface with a method that returns a tuple containing all the properties of the radio last mile
/// </summary>
public interface ILastMileRadio
{

    (
        string? ODUSerialNumber, string? IDUSerialNumber, 
        string? RadioManagementVLAN,
        string? RadioFrequency, string? RadioManagementIPAtPoP,
        string? RadioManagementIPAtClient,
        string? ManagedRadioIPGateway,
        string? SubnetMaskForManagementIP
    ) 
        LastMileRadioInfo(string? ODUSerialNumber, string? IDUSerialNumber,
        string? RadioManagementVLAN,
        string? RadioFrequency, string? RadioManagementIPAtPoP,
        string? RadioManagementIPAtClient,
        string? ManagedRadioIPGateway,
        string? SubnetMaskForManagementIP);
}
