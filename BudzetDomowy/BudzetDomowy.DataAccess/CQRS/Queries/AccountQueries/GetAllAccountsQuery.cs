using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS.Queries.AccountQueries
{
    public class GetAllAccountsQuery : QueryBase<List<Account>>
    {
        public override async Task<List<Account>> Execute(HouseholdBudgetStorageContext context)
        {
            var accounts = await context.Accounts.ToListAsync();
            return accounts;
        }
    }
}
