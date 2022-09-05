using MediatR;

namespace BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses
{
    public class DeleteShopRequest : IRequest<DeleteShopResponse>
    {
        public int ShopId { get; set; }
    }
}
