namespace OmniCore.Domain.Entities.CircuitManagement;
/// <summary>
/// Types of services offered eg FTTH, internet, PRI, Leased Line etc
/// </summary>
public class Service
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}
