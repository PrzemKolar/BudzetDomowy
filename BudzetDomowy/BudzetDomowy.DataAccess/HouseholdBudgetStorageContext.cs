using Microsoft.EntityFrameworkCore;

namespace BudzetDomowy.DataAccess
{
    public class HouseholdBudgetStorageContext : DbContext
    {
        public HouseholdBudgetStorageContext(DbContextOptions<HouseholdBudgetStorageContext> opt) : base(opt)
        {

        }

    }
}
