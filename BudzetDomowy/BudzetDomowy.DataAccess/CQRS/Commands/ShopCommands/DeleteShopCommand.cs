using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Commands.ShopCommands
{
    public class DeleteShopCommand : CommandBase<Shop, Shop>
    {
        public int ShopId { get; set; }

        public override async Task<Shop> Execute(HouseholdBudgetStorageContext context)
        {
            var shop = await context.Shops.FirstOrDefaultAsync(x => x.Id == this.ShopId);
            context.Shops.Remove(shop);
            await context.SaveChangesAsync();
            return shop;
        }
    }
}
