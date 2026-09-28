using OmniCore.Domain.Common;
using OmniCore.Domain.Entities.ClientManagement.Enums;
using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.Ticketing;


/// <summary>
/// A trouble ticket
/// </summary>
public class Ticket:AuditableEntity
{
    public Guid TicketId { get; set; }
    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
    public Guid? LinkId { get; set; }
    public Link? Link { get; set; }
    public TicketType TicketType { get; set; }
    public TicketStatus? TicketStatus { get; set; }
    public TicketPriority TicketPriority { get; set; }
    public LinkStatus LinkStatus { get; set; }
    public string? Title { get; set; }
    public string? DescriptionOfIssue { get; set; }
    public DateTime ClosedAt { get; set; }

    public TimeSpan? TicketAging => CreatedDate - ClosedAt;
}

