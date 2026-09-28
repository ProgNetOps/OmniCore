namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// An owned entity of the Link Class
/// </summary>
public class AccountDetails
{
    public string? NameOfAccountManager { get; set; }
    public string? NameOfProjectManager { get; set; }
    public double? AnnualRevenue { get; set; }
    public double? Bandwidth { get; set; }
    public DateTime? JCCSignDate { get; set; }
    public string? InstallersContactDetails { get; set; }
}
