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

namespace BudzetDomowy.ApplicationServices.API.Handlers.ShopHandlers
{
    public class DisableAccountHandler : IRequestHandler<DisableAccountRequest, DisableAccountResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public DisableAccountHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<DisableAccountResponse> Handle(DisableAccountRequest request, CancellationToken cancellationToken)
        {
            var command = new DisableAccountCommand() { AccountId = request.AccountId };
            var account = await this.commandExecutor.Execute(command);
            return new DisableAccountResponse() { Data = this.mapper.Map<Account>(account) };
        }
    }
}
