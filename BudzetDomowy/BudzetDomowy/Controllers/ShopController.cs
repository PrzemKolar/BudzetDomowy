using BudzetDomowy.DataAccess;
using BudzetDomowy.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BudzetDomowy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly IRepository<Shop> ShopRepository;

        public ShopController(IRepository<Shop> shopRepository)
        {
            this.ShopRepository = shopRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Shop> GetAllShops() => this.ShopRepository.GetAll();

        [HttpGet]
        [Route("{shopId}")]
        public Shop GetAllShopById(int shopId) => this.ShopRepository.GetById(shopId);
    }
}
