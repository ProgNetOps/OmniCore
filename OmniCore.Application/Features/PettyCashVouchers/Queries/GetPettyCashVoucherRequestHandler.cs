using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.PettyCashVouchers.Queries;

public class GetPettyCashVoucherRequestHandler : IRequestHandler<GetPettyCashVouchersListQuery, List<PettyCashVoucherListVm>>
{
    public Task<List<PettyCashVoucherListVm>> Handle(GetPettyCashVouchersListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
