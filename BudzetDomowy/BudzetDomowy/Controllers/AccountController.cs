using MediatR;
using Microsoft.AspNetCore.Mvc;
using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;

namespace BudzetDomowy.Controllers
{
    public class AccountController : ApiControllerBase
    {

        public AccountController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllAcconts([FromQuery] GetAllAccountsRequest request)
        {
            return this.HandleRequest<GetAllAccountsRequest, GetAllAccountsResponse>(request);
        }

        [HttpGet]
        [Route("{AccountId}")]
        public Task<IActionResult> GetAccountById([FromRoute] int AccountId)
        {
            return this.HandleRequest<GetAccountByIdRequest,GetAccountByIdResponse>(new GetAccountByIdRequest() { AccountId = AccountId });
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddAccount([FromBody] AddAccountRequest request)
        {
            return this.HandleRequest<AddAccountRequest, AddAccountResponse>(request);
        }

        [HttpPut]
        [Route("")]
        public Task<IActionResult> EditAccount([FromBody] EditAccountRequest request)
        {
            return this.HandleRequest<EditAccountRequest, EditAccountResponse>(request);
        }

        [HttpPut]
        [Route("{AccountId}")]
        public Task<IActionResult> DisableAccount([FromRoute] int AccountId)
        {
            return this.HandleRequest<DisableAccountRequest, DisableAccountResponse>(new DisableAccountRequest(){ AccountId = AccountId});
        }
    }
}
