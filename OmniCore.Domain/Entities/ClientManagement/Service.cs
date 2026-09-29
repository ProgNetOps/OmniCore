namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Types of services offered eg FTTH, Internet, PRI, LeasedLine, SIP, IPSec etc
/// </summary>
public abstract class Service
{
    public Guid ServiceId { get; set; }
    public int? ServiceVLAN { get; set; }
    public Guid IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }
    public ICollection<BTS>? TransmissionPath { get; set; }
    public double? PathLength { get; set; }
    public string? ServiceImprovementPlan { get; set; }
}
