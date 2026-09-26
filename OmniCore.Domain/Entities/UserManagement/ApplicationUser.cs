namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// An abstract child class of framework's IdentityUser class, acting as an extension point for concrete Customer and Employee classes
/// </summary>
public abstract class ApplicationUser
{
    public Guid UserCategoryId { get; set; }
    public UserCategory? UserCategory { get; set; }
    public string? PhotoPath { get; set; }

}
