using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Commands.AccountCommands
{
    public class DisableAccountCommand : CommandBase<Account, Account>
    {
        public int AccountId { get; set; }
        public override async Task<Account> Execute(HouseholdBudgetStorageContext context)
        {
            var account = await context.Accounts.FirstOrDefaultAsync(x => x.Id == this.AccountId);
            account.Enabled = false;
            await context.SaveChangesAsync();
            return account;
        }
    }
}
