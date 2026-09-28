using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// The identity class for Glo staff, it is a discriminator in the database
/// </summary>
public class Employee : ApplicationUser
{
    public Guid EmployeeId { get; set; }
    public Guid? UnitId { get; set; }
    public Unit? Unit { get; set; }
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? FullName => $"{Surname} {FirstName}";
    public DateTime? OnboardingDate { get; set; }
    public int? StateId { get; set; }
    public State? State { get; set; }
    public string? OfficeAddress { get; set; }
    public string? AlternateNumber { get; set; }
    public Gender? Gender { get; set; }


}

