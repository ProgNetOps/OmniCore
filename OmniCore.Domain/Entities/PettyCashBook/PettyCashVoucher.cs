using OmniCore.Domain.Common;
using OmniCore.Domain.Entities.ClientManagement;
using OmniCore.Domain.Entities.UserManagement;

namespace OmniCore.Domain.Entities.PettyCashBook;

public class PettyCashVoucher:AuditableEntity
{
    public Guid VoucherId { get; set; }
    public string? PurposeOfVoucher { get; set; }
    public Employee? EngineerInCharge { get; set; }
    public Employee? Payee { get; set; }
    public double Amount { get; set; }
    public Circuit? Circuit { get; set; }
    public string? Problem { get; set; }
}
