using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Commands.AccountCommands
{
    public class EditAccountCommand : CommandBase<Account, Account>
    {
        public override async Task<Account> Execute(HouseholdBudgetStorageContext context)
        {
            var account = await context.Accounts.FirstOrDefaultAsync(x => x.Id == Parameter.Id);
            account.Name = Parameter.Name;
            await context.SaveChangesAsync();
            return account;
        }
    }
}
