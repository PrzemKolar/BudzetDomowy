using BudzetDomowy.DataAccess.CQRS.Commands;

namespace BudzetDomowy.DataAccess.CQRS
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParameter, TResult>(CommandBase<TParameter,TResult> command);
    }
}
