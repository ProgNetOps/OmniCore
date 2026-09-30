using OmniCore.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.CeragonRadioLastMiles.Queries;

public class GetCeragonRadioLastMilesListQueryHandler
    (ICeragonRadioLastMileRepository ceragonRadioLastMileRepository,
    IMapper mapper) 
    : IRequestHandler<GetCeragonRadioLastMilesListQuery, List<CeragonRadioLastMileListVm>>
{
    private readonly ICeragonRadioLastMileRepository _ceragonRadioLastMileRepository=ceragonRadioLastMileRepository;
    private readonly IMapper _mapper=mapper;
    public Task<List<CeragonRadioLastMileListVm>> Handle(GetCeragonRadioLastMilesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
