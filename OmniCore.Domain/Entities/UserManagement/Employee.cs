using OmniCore.Domain.Entities.Geography;

namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// The identity class for Glo staff, it is a discriminator in the database
/// </summary>
public class Employee : ApplicationUser
{
    public Guid? UnitId { get; set; }
    public Unit? Unit { get; set; }
    public string? LineManagerId { get; set; }
    public Employee? LineManager { get; set; }
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    //public string? FullName => $"{Surname} {FirstName} - {PhoneNumber}";
    public DateOnly? OnboardingDate { get; set; }
    public int? StateId { get; set; }
    public State? State { get; set; }
    public string? OfficeAddress { get; set; }
    public string? AlternateNumber { get; set; }
    public Guid? GenderId { get; set; }
    public Gender? Gender { get; set; }


}

