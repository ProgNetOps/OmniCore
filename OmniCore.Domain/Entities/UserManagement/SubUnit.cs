namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// The Sub Departments in Enterprise Business Group
/// </summary>
public class SubUnit:AuditableEntity
{
    public Guid SubUnitId { get; set; }
    public string? Name { get; set; }
    public Employee? HeadOfUnit { get; set; }
    public ICollection<Employee>? MembersOfUnit { get; set; }
}