using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Commands.ShopCommands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Handlers.ShopHandlers
{
    public class DeleteShopHandler : IRequestHandler<DeleteShopRequest,DeleteShopResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public DeleteShopHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<DeleteShopResponse> Handle(DeleteShopRequest request, CancellationToken cancellationToken)
        {
            var command = new DeleteShopCommand() { ShopId = request.ShopId };
            var shopFromDB = await this.commandExecutor.Execute(command);
            return new DeleteShopResponse() { Data = mapper.Map<Shop>(shopFromDB) };
        }
    }
}
