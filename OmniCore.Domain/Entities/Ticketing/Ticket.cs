using OmniCore.Domain.Common;
namespace OmniCore.Domain.Entities.Ticketing;


/// <summary>
/// A trouble ticket
/// </summary>
public class Ticket:AuditableEntity
{
    public Guid Id { get; set; }
    public Guid? ClientId { get; set; }
    public Client? Client { get; set; }
    public Guid? CircuitId { get; set; }
    public Circuit? Circuit { get; set; }
    public Guid? TicketTypeId { get; set; }
    public TicketType? TicketType { get; set; }
    public Guid? TicketStatusId { get; set; }
    public TicketStatus? TicketStatus { get; set; }
    public Guid? TicketPriorityId { get; set; }
    public TicketPriority? TicketPriority { get; set; }
    public string? IssueTitle { get; set; }
    public string? ShortDescription { get; set; }
    public string? FullDescription { get; set; }
    public DateTime ClosedAt { get; set; }

    public TimeSpan? TicketAging => CreatedDate - ClosedAt;
}

