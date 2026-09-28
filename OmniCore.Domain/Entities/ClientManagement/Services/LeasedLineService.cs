namespace OmniCore.Domain.Entities.ClientManagement.Services;

public class LeasedLineService:Service
{
    public Guid LeasedLineServiceId { get; set; }
    public string? NameOfService { get; set; }
    public string? CustomerWANIP { get; set; }
    public string? SubnetMask { get; set; }
    public string? Gateway { get; set; }
}
