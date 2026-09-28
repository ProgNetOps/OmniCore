namespace OmniCore.Domain.Entities.UserManagement;
/// <summary>
/// The Identity class for customer users of the application, representing a discriminator in the database
/// </summary>
public class Customer : ApplicationUser
{
    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
    public string? CustomerName { get; set; }
}