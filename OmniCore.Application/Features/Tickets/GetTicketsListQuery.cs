using MediatR;

namespace OmniCore.Application.Features.Tickets;
/// <summary>
/// Message
/// </summary>
public class GetTicketsListQuery:IRequest<List<TicketListVm>>
{
}
