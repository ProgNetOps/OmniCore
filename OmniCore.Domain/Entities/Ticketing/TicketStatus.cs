namespace OmniCore.Domain.Entities.Ticketing;

/// <summary>
/// The current status of the ticket; used to communicates the progress on resolutions of escalated issues to customer 
/// </summary>
public class TicketStatus
{
    public Guid Id { get; set; }
    public string? Status { get; set; }
}
