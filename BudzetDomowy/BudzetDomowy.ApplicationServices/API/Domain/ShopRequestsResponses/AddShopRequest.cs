using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses
{
    public class AddShopRequest : IRequest<AddShopResponse>
    {
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
