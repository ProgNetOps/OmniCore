using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.AlcatelRadioLastMiles;

public class GetAlcatelRadioLastMilesListQueryHandler 
    (IAlcatelRadioLastMileRepository alcatelRadioLastMileRepository,
    IMapper mapper)
    : IRequestHandler<GetAlcatelRadioLastMilesListQuery, List<AlcatelRadioLastMileListVm>>
{
    private readonly IAlcatelRadioLastMileRepository _alcatelRadioLastMileRepository = alcatelRadioLastMileRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<AlcatelRadioLastMileListVm>> Handle(GetAlcatelRadioLastMilesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
