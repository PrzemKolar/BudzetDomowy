using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess
{
    public class HouseholdBudgetStorageContextFactory : IDesignTimeDbContextFactory<HouseholdBudgetStorageContext>
    {
        public HouseholdBudgetStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HouseholdBudgetStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=HouseholdBudgetStorage;Integrated Security=True");
            return new HouseholdBudgetStorageContext(optionsBuilder.Options);
        }
    }
}
