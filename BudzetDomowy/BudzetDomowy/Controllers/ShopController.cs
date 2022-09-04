using MediatR;
using Microsoft.AspNetCore.Mvc;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;

namespace BudzetDomowy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly IMediator mediator;

        public ShopController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllShops([FromQuery]GetAllShopsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        //[HttpGet]
        //[Route("{shopId}")]
        //public Shop GetAllShopById(int shopId) => this.ShopRepository.GetById(shopId);
    }
}
