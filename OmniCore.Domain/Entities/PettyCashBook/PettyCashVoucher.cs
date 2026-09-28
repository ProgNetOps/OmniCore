namespace OmniCore.Domain.Entities.PettyCashBook;

public class PettyCashVoucher:AuditableEntity
{
    public Guid VoucherId { get; set; }
    public string? PurposeOfVoucher { get; set; }
    public Employee? EngineerInCharge { get; set; }
    public Employee? Payee { get; set; }
    public double Amount { get; set; }
    public Link? Link { get; set; }
    public int PettyCashBookId{ get; set; }
    //public PettyCashBook PettyCashBook { get; set; } = default!;
    //public string? DescriptionOfProblem { get; set; }


    //List of Approvers

}
