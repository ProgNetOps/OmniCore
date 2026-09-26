using OmniCore.Domain.Entities.UserManagement;

namespace OmniCore.Domain.Entities.CircuitManagement;

/// <summary>
/// The identity class for Glo Technology Partners, it is a discriminator in the database
/// </summary>
public class TechnologyPartner : ApplicationUser
{
    public string? CompanyName { get; set; }
    public string? OfficeAddress { get; set; }

}
