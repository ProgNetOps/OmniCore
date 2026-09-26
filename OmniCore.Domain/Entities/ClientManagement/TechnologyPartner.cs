using OmniCore.Domain.Entities.UserManagement;

namespace OmniCore.Domain.Entities.ClientManagement;

/// <summary>
/// The identity class for Glo Technology Partners, it is a discriminator in the database
/// </summary>
public class TechnologyPartner : ApplicationUser
{
    public Guid TechnologyPartnerId { get; set; }
    public string? CompanyName { get; set; }
    public string? OfficeAddress { get; set; }

}
