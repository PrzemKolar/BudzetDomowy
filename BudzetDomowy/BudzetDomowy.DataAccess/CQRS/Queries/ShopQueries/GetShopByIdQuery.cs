using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Queries.ShopQueries
{
    public class GetShopByIdQuery : QueryBase<Shop>
    {
        public int ShopId { get; set; }

        public async override Task<Shop> Execute(HouseholdBudgetStorageContext context)
        {
            return await context.Shops.FirstOrDefaultAsync(x => x.Id == this.ShopId);
        }
    }
}
