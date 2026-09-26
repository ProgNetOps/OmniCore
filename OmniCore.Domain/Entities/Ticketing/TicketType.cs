using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.Ticketing;
/// <summary>
/// The categorization of trouble tickets
/// </summary>
public class TicketType:AuditableEntity
{
    public Guid TicketTypeId { get; set; }
    public string? TypeOfTicket { get; set; }
}