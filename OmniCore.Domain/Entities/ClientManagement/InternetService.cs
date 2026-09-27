namespace OmniCore.Domain.Entities.ClientManagement;

public class InternetService:Service
{
    public Guid InternetServiceId { get; set; }
    public string? NameOfService { get; set; }
    public string? CustomerPublicIP { get; set; }
    public string? SubnetMask { get; set; }
    public string? Gateway { get; set; }
    public Guid IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }
    public string? Glo1RouterManagementIP { get; set; }
}
