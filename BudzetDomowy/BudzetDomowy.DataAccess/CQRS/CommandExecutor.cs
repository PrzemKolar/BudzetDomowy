using BudzetDomowy.DataAccess.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly HouseholdBudgetStorageContext context;

        public CommandExecutor(HouseholdBudgetStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TParameter, TResult>(CommandBase<TParameter, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
