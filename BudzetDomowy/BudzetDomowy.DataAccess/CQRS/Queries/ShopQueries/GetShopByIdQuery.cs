using BudzetDomowy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Queries.ShopQueries
{
    public class GetShopByIdQuery : QueryBase<Shop>
    {
        public int ShopId { get; set; }

        public async override Task<Shop> Execute(HouseholdBudgetStorageContext context)
        {
            return await context.Shops.FindAsync(this.ShopId);
        }
    }
}
