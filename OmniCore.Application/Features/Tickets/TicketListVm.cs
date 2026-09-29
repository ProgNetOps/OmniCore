using OmniCore.Domain.Entities.ClientManagement.Enums;
using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Application.Features.Tickets;
/// <summary>
/// Data to visualize when a list of ticket is displayed
/// </summary>
public class TicketListVm
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
}