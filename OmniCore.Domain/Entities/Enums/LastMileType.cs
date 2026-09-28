namespace OmniCore.Domain.Entities.Enums;
/// <summary>
/// The transmission device for service delivery from the ip pop to customer 
/// location: Nera, Ceragon, Huawei, TDMoEConverter, E1ToEthernetConverter,
/// FiberToEthernetConverter, ThirdPartyRadio
/// </summary>
public enum LastMileType
{
    Nera=1,
    Ceragon,
    Huawei,
    Alcatel,
    ThirdPartyRadio,
    Fiber
}
