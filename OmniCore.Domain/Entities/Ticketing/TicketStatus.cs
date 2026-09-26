using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.Ticketing;

/// <summary>
/// The current status of the ticket; used to communicates the progress on resolutions of escalated issues to customer 
/// </summary>
public class TicketStatus:AuditableEntity
{
    public Guid Id { get; set; }
    public string? Status { get; set; }
}
