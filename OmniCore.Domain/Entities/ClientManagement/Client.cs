using OmniCore.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Class that represents organizations that are clients to Globacom Enterprise Business
/// </summary>
public class Client:AuditableEntity
{    
    public Guid ClientId { get; set; }
    public string? ClientName { get; set; }
    public Guid ClientCategoryId { get; set; }
    public ClientCategory? ClientCategory { get; set; }       
    public ICollection<Link>? Links { get; set; }
}
