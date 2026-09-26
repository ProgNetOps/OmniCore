namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Types of services offered eg FTTH, Internet, PRI, Leased Line, SIP
/// </summary>
public class Service
{
    public Guid ServiceId { get; set; }
    public string? Name { get; set; }
}
