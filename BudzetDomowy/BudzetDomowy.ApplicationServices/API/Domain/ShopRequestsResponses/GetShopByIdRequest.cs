using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses
{
    public class GetShopByIdRequest : IRequest<GetShopByIdResponse>
    {
        public int ShopId { get; set; }
    }
}
