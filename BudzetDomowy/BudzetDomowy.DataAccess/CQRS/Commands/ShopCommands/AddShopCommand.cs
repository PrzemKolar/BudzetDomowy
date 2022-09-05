using BudzetDomowy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Commands.ShopCommands
{
    public class AddShopCommand : CommandBase<Shop, Shop>
    {
        public async override Task<Shop> Execute(HouseholdBudgetStorageContext context)
        {
            await context.Shops.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
