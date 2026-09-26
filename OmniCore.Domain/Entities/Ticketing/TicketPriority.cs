using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.Ticketing;
/// <summary>
/// The priority a trouble ticket has that indicates the urgency it gets for resolution
/// </summary>
public class TicketPriority:AuditableEntity
{
    public Guid Id { get; set; }

    public string? Priority { get; set; }


}