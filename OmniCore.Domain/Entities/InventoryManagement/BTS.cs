namespace OmniCore.Domain.Entities.InventoryManagement;
/// <summary>
/// Class that represents the Base Station
/// </summary>
public class BTS
{   
    public Guid BTSId { get; set; }
    public string? BTSName { get; set; }
    public Address? LocationOfBaseStation { get; set; }
}
