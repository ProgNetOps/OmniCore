using OmniCore.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Clients.Queries;

public class GetClientsListQueryHandler 
    (IClientRepository clientRepository,
    IMapper mapper)
    : IRequestHandler<GetClientsListQuery, List<ClientListVm>>
{
    private readonly IClientRepository _clientRepository= clientRepository;
    private readonly IMapper _mapper = mapper;
    public Task<List<ClientListVm>> Handle(GetClientsListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
