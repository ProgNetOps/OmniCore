using OmniCore.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Zones.Queries;

public class GetZonesListQueryHandler
    (IZoneRepository zoneRepository,
    IMapper mapper) 
    : IRequestHandler<GetZonesListQuery, List<ZoneListVm>>
{
    private readonly IMapper _mapper = mapper;
    private readonly IZoneRepository _zoneRepository = zoneRepository;
    public Task<List<ZoneListVm>> Handle(GetZonesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
