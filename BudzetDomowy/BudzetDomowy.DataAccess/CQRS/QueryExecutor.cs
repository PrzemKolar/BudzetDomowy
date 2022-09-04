using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudzetDomowy.DataAccess.CQRS.Queries;

namespace BudzetDomowy.DataAccess.CQRS
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly HouseholdBudgetStorageContext context;

        public QueryExecutor(HouseholdBudgetStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(context);
        }
    }
}
