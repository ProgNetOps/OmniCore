using OmniCore.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmniCore.Domain.Entities;
/// <summary>
/// Class that represents organizations that are clients to Globacom Enterprise Business
/// </summary>
public class Client:AuditableEntity
{
    
    public Guid Id { get; set; }

    /// <summary>
    /// Name of client/customer
    /// </summary>
    public string? ClientName { get; set; }
    public Guid ClientCategoryId { get; set; }
    public ClientCategory? ClientCategory { get; set; }
       
    public List<Circuit>? Circuits { get; set; }
}
