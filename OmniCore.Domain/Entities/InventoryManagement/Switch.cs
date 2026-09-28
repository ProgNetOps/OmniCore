using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement;

/// <summary>
/// Represents the switch on which clients' services are provisioned/ configured
/// </summary>
public class Switch:NetworkElement
{
    public Guid SwitchId { get; set; }
    /// <summary>
    /// A collection of DCN uplink routers and Glo1 Core routers
    /// </summary>
    public ICollection<Router>? ConnectedRouters { get; set; }
    public ICollection<string>? DCNUplinkRouterInterfaces { get; set; }
    public override NEType? NetworkElementType { get; set; } = NEType.Switch;
}