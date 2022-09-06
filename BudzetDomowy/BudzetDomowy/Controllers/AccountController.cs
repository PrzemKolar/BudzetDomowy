﻿using MediatR;
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
    }
}
