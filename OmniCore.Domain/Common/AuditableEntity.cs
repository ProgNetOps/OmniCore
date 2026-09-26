using OmniCore.Domain.Entities.UserManagement;

namespace OmniCore.Domain.Common;

public class AuditableEntity
{
    public ApplicationUser? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public ApplicationUser? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}
