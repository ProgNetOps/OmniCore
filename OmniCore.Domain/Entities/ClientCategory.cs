namespace OmniCore.Domain.Entities;

public class ClientCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Client>? Clients { get; set; }
}
