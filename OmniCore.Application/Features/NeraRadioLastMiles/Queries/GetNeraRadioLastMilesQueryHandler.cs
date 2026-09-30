using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.NeraRadioLastMiles.Queries
{
    public class GetNeraRadioLastMilesQueryHandler : IRequestHandler<GetNeraRadioLastMilesQuery, List<NeraRadioLastMileListVm>>
    {
        public Task<List<NeraRadioLastMileListVm>> Handle(GetNeraRadioLastMilesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
