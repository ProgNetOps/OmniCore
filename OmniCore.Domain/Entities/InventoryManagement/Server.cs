using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement;

public class Server:NetworkElement
{
    public Guid ServerId { get; set; }
    public ICollection<Switch>? ConnectedSwitches { get; set; }
    public ICollection<Router>? ConnectedRouters { get; set; }
    public override NEType? NetworkElementType { get; set; } = NEType.Server;
}
