namespace OmniCore.Domain.Entities.ClientManagement.Services;

public class InternetService:Service
{
    public Guid InternetServiceId { get; set; }
    public string? NameOfService { get; set; }
    public string? CustomerPublicIP { get; set; }
    public string? SubnetMask { get; set; }
    public string? Gateway { get; set; }


    public Guid Glo1RouterId { get; set; }
    public Router? Glo1Router { get; set; }
}
