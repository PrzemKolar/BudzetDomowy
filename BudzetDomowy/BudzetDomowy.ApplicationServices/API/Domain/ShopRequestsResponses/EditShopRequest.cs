using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses
{
    public class EditShopRequest : IRequest<EditShopResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
