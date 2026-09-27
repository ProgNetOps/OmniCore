namespace OmniCore.Domain.Entities.InventoryManagement;

/// <summary>
/// The transmission device for service delivery from the ip pop to customer 
/// location: Nera, Ceragon, Huawei, TDMoEConverter, E1ToEthernetConverter,
/// FiberToEthernetConverter, ThirdPartyRadio
/// </summary>

public class LastMileDevice
{
    public Guid Id { get; set; }
    public string? LastMileDeviceName { get; set; }
}

