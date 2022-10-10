using MediatR;
using Microsoft.AspNetCore.Mvc;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;

namespace BudzetDomowy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ApiControllerBase
    {

        public ShopController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllShops([FromQuery]GetAllShopsRequest request)
        {
            return this.HandleRequest<GetAllShopsRequest,GetAllShopsResponse>(request);
        }

        [HttpGet]
        [Route("{ShopId}")]
        public Task<IActionResult> GetShopById([FromRoute]int ShopId)
        {
            return this.HandleRequest<GetShopByIdRequest, GetShopByIdResponse>(new GetShopByIdRequest() { ShopId = ShopId });
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddShop([FromBody] AddShopRequest request)
        {
            return this.HandleRequest<AddShopRequest, AddShopResponse>(request);
        }

        [HttpPut]
        [Route("")]
        public Task<IActionResult> EditShop([FromBody] EditShopRequest request)
        {
            return this.HandleRequest<EditShopRequest, EditShopResponse>(request);
        }

        [HttpDelete]
        [Route("{ShopId}")]
        public Task<IActionResult> DeleteShop([FromRoute] int ShopId)
        {
            return this.HandleRequest<DeleteShopRequest, DeleteShopResponse>(new DeleteShopRequest() { ShopId = ShopId });
        }
    }
}
