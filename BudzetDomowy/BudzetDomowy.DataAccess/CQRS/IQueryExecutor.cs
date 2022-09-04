using BudzetDomowy.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS
{
    public interface IQueryExecutor
    {
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
