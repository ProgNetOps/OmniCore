using OmniCore.Domain.Entities.CircuitManagement;

namespace OmniCore.Domain.Entities.InfrastructureManagement;
/// <summary>
/// The base station where services are provisioned on network equipment for customers
/// </summary>
public class IPPoP
{
    public Guid Id { get; set; }

    /// <summary>
    /// Site Id of the point of Preference
    /// </summary>
    public string? IPPoPName { get; set; }

    public Guid? BTSId { get; set; }
    public BTS? BTS { get; set; }

    /// <summary>
    /// List of switches at the PoP
    /// </summary>
    public ICollection<NetworkSwitch>? Switches { get; set; }

    /// <summary>
    /// List of DCN routers at the PoP
    /// </summary>
    public ICollection<DCNRouter>? Routers { get; set; }

    public ICollection<Circuit>? Circuits { get; set; }
}
