namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Group based on Glo Enterprise's categorization
/// Banking, OilAndGas, NonCore, Manufacturing etc
/// </summary>
public class ClientCategory
{
    public Guid ClientCategoryId { get; set; }
    public string? Name { get; set; }
    public List<Client>? Clients { get; set; }
}
