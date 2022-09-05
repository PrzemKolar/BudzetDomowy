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

        [HttpGet]
        [Route("{ShopId}")]
        public async Task<IActionResult> GetShopById([FromRoute]int ShopId)
        {
            var request = new GetShopByIdRequest() { ShopId = ShopId };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddShop([FromBody] AddShopRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> EditShop([FromBody] EditShopRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
