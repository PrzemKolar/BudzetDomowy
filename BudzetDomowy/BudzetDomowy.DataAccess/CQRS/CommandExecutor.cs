using BudzetDomowy.DataAccess.CQRS.Commands;

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
