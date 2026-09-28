namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// The Sub Departments in Enterprise Business Group
/// </summary>
public class Unit:AuditableEntity
{
    public Guid UnitId { get; set; }
    public string? Name { get; set; }
    public Employee? HeadOfUnit { get; set; }
    public ICollection<Employee>? MembersOfUnit { get; set; }
}