using OmniCore.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.IPPoPs.Queries
{
    public class GetIPPoPsListQueryHandler
        (IIPPoPRepository iPPoPRepository,
        IMapper mapper)
        : IRequestHandler<GetIPPoPsListQuery, List<IPPoPListVm>>
    {
        private readonly IIPPoPRepository _iPPoPRepository=iPPoPRepository;
        private readonly IMapper _mapper = mapper;
        public Task<List<IPPoPListVm>> Handle(GetIPPoPsListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
