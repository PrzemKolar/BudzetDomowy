using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses
{
    public class GetAllAccountsRequest : IRequest<GetAllAccountsResponse>
    {
    }
}
