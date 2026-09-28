namespace OmniCore.Domain.Entities.PettyCashBook;

public class PettyCashBook
{
    public int PettyCashBookId { get; set; } = 1;
    /// <summary>
    /// The imprest
    /// </summary>
    public double Float { get; set; } = 0.00;
    public ICollection<PettyCashVoucher>? PettyCashVouchers { get; set; }
}
