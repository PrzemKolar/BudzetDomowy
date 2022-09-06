using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Commands.AccountCommands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Handlers.AccountHandlers
{
    public class EditAccountHandler : IRequestHandler<EditAccountRequest, EditAccountResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public EditAccountHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<EditAccountResponse> Handle(EditAccountRequest request, CancellationToken cancellationToken)
        {
            var account = this.mapper.Map<DataAccess.Entities.Account>(request);
            var command = new EditAccountCommand(){ Parameter = account};
            var accountFromDB = await this.commandExecutor.Execute(command);
            return new EditAccountResponse() { Data = this.mapper.Map<Account>(accountFromDB) };
        }
    }
}
