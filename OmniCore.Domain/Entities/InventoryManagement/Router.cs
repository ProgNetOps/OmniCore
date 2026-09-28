using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement;

public class Router : NetworkElement
{
    public Guid RouterId {get; set;}
    public override NEType? NetworkElementType { get; set; } = NEType.Router;
}
