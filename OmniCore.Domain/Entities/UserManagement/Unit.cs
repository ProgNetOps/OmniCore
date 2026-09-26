using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.UserManagement;

/// <summary>
/// The Sub Departments in Enterprise Business Group
/// </summary>
public class Unit:AuditableEntity
{
    public Guid UnitId { get; set; }
    public string? Name { get; set; }
    public Employee? UnitHead { get; set; }
}