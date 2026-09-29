using MediatR;

namespace OmniCore.Application.Features.Tickets.Queries;
/// <summary>
/// Message
/// </summary>
public class GetTicketsListQuery:IRequest<List<TicketListVm>>
{
}
