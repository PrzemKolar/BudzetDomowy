using MediatR;
using Microsoft.AspNetCore.Mvc;
using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;

namespace BudzetDomowy.Controllers
{
    public class AccountController : ControllerBase
    {
        private IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllAcconts([FromQuery] GetAllAccountsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{AccountId}")]
        public async Task<IActionResult> GetAccountById([FromRoute] int AccountId)
        {
            var response = await this.mediator.Send(new GetAccountByIdRequest() { AccountId = AccountId });
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddAccount([FromBody] AddAccountRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> EditAccount([FromBody] EditAccountRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("{AccountId}")]
        public async Task<IActionResult> DisableAccount([FromRoute] int AccountId)
        {
            var response = await this.mediator.Send(new DisableAccountRequest(){ AccountId = AccountId});
            return this.Ok(response);
        }
    }
}
