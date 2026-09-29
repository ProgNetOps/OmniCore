using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.Tickets;
/// <summary>
/// Message Handler for GetTicketsListQuery
/// </summary>
public class GetTicketsListQueryHandler
    (ITicketRepository ticketRepository,
    IMapper mapper) 
    : IRequestHandler<GetTicketsListQuery, List<TicketListVm>>
{
    private readonly ITicketRepository _ticketRepository = ticketRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<TicketListVm>> Handle(GetTicketsListQuery request, CancellationToken cancellationToken)
    {
        var allTickets = (await _ticketRepository.GetAllAsync())
            .OrderBy(x => x.CreatedDate);

        return _mapper.Map<List<TicketListVm>>(allTickets);
    }
}
