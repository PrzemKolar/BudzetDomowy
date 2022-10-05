using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudzetDomowy.DataAccess.CQRS.Queries.AccountQueries
{
    public class GetAccountByIdQuery : QueryBase<Account>
    {
        public int AccountId { get; set; }

        public async override Task<Account> Execute(HouseholdBudgetStorageContext context)
        {
            return await context.Accounts.FirstOrDefaultAsync(x => x.Id == AccountId);
        }
    }
}
