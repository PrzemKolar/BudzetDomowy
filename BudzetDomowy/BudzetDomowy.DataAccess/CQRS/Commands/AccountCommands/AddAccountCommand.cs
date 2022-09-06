using BudzetDomowy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Commands.AccountCommands
{
    public class AddAccountCommand : CommandBase<Account, Account>
    {
        public override async Task<Account> Execute(HouseholdBudgetStorageContext context)
        {
            this.Parameter.Value = 0;
            this.Parameter.Enabled = true;
            await context.Accounts.AddAsync(Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
