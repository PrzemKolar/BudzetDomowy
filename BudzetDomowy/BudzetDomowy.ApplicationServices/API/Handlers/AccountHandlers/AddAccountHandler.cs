using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Commands.AccountCommands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Handlers.AccountHandlers
{
    public class AddAccountHandler : IRequestHandler<AddAccountRequest, AddAccountResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddAccountHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddAccountResponse> Handle(AddAccountRequest request, CancellationToken cancellationToken)
        {
            var account = this.mapper.Map<DataAccess.Entities.Account>(request);
            var command = new AddAccountCommand() { Parameter = account };
            var accountFromDB = await this.commandExecutor.Execute(command);
            return new AddAccountResponse() { Data = this.mapper.Map<Account>(accountFromDB) };
        }
    }
}
