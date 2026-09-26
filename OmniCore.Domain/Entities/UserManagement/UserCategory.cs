using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// A categorization for users of the application
/// </summary>
public class UserCategory:AuditableEntity
{
    public Guid UserCategoryId { get; set; }
    public string? CategoryOfApplicationUser { get; set; }
}