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

        

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddAccount([FromBody] AddAccountRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
