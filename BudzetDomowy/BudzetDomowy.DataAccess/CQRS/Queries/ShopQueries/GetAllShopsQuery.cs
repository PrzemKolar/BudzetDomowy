using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Queries.ShopQueries
{
    public class GetAllShopsQuery : QueryBase<List<Shop>>
    {
        public async override Task<List<Shop>> Execute(HouseholdBudgetStorageContext context)
        {
            return await context.Shops.ToListAsync();
        }
    }
}
