using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Commands.ShopCommands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Handlers.ShopHandlers
{
    public class AddShopHandler : IRequestHandler<AddShopRequest,AddShopResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddShopHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddShopResponse> Handle(AddShopRequest request, CancellationToken cancellationToken)
        {
            var shop = this.mapper.Map<DataAccess.Entities.Shop>(request);
            var command = new AddShopCommand() { Parameter = shop };
            var shopFromDb = await this.commandExecutor.Execute(command);
            return new AddShopResponse() { Data = this.mapper.Map<Shop>(shopFromDb) };
        }
    }
}
