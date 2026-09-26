namespace OmniCore.Domain.Entities.Ticketing;
/// <summary>
/// The priority a trouble ticket has that indicates the urgency it gets from customer care agents and technical support engineers
/// </summary>
public class TicketPriority
{
    public Guid Id { get; set; }

    public string? Priority { get; set; }


}