using OmniCore.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.FiberLastMiles.Queries;

public class GetFiberLastMilesListQueryHandler
    (IFiberLastMileRepository fiberLastMileRepository,
    IMapper mapper)
    : IRequestHandler<GetFiberLastMilesListQuery, List<FiberLastMileListVm>>
{
    private readonly IFiberLastMileRepository _fiberLastMileRepository = fiberLastMileRepository;
    private readonly IMapper _mapper = mapper;
    public Task<List<FiberLastMileListVm>> Handle(GetFiberLastMilesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
