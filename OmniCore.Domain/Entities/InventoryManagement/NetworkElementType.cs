namespace OmniCore.Domain.Entities.InventoryManagement;
/// <summary>
/// The specific type such as Router, Switch, Server, NeraRadioUnit,
/// CeragonRadioUnit, HuaweiRadioUnit, ThirdPartyRadioUnit
/// </summary>
public class NetworkElementType
{
    public Guid NetworkElementTypeId { get; set; }
    public string? NetworkElementTypeName { get; set; }
}
