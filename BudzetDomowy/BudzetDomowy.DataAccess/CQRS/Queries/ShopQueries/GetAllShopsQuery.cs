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
        public string Name { get; set; }

        public async override Task<List<Shop>> Execute(HouseholdBudgetStorageContext context)
        {
            if (Name == null)
                return await context.Shops.ToListAsync();
            else
                return await context.Shops.Where(x => x.Name == Name).ToListAsync();
        }
    }
}
