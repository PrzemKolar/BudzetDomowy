using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Commands.ShopCommands;
using MediatR;

namespace BudzetDomowy.ApplicationServices.API.Handlers.ShopHandlers
{
    public class EditShopHandler : IRequestHandler<EditShopRequest,EditShopResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public EditShopHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<EditShopResponse> Handle(EditShopRequest request, CancellationToken cancellationToken)
        {
            var shop = this.mapper.Map<DataAccess.Entities.Shop>(request);
            var command = new EditShopCommand() { Parameter = shop };
            var shopFromDb = await this.commandExecutor.Execute(command);
            return new EditShopResponse() { Data = this.mapper.Map<Shop>(shopFromDb) };
        }
    }
}
