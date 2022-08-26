using BudzetDomowy.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudzetDomowy.DataAccess
{
    public class HouseholdBudgetStorageContext : DbContext
    {
        public HouseholdBudgetStorageContext(DbContextOptions<HouseholdBudgetStorageContext> opt) : base(opt)
        {

        }

        public DbSet<Shop>  Shops { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Earning> Earnings { get; set; }
        public DbSet<DueExpense> DueExpenses { get; set; }
        public DbSet<ConstantExpense> ConstantExpenses { get; set; }

    }
}
