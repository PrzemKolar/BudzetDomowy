using MediatR;

namespace BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses
{
    public class EditAccountRequest : IRequest<EditAccountResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
