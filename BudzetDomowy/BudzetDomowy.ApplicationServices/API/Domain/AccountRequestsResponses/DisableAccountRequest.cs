using MediatR;

namespace BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses
{
    public class DisableAccountRequest : IRequest<DisableAccountResponse>
    {
        public int AccountId { get; set; }
    }
}
