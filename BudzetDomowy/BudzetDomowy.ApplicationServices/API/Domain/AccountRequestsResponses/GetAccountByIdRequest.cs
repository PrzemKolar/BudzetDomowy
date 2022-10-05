using MediatR;

namespace BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses
{
    public class GetAccountByIdRequest : IRequest<GetAccountByIdResponse>
    {
        public int AccountId { get; set; }
    }
}
