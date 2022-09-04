using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Queries.ShopQueries;
using MediatR;

namespace BudzetDomowy.ApplicationServices.API.Handlers.ShopHandlers
{
    public class GetAllShopsHandler : IRequestHandler<GetAllShopsRequest, GetAllShopsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetAllShopsHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;   
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetAllShopsResponse> Handle(GetAllShopsRequest request, CancellationToken cancellationToken)
        {
            var shops = await this.queryExecutor.Execute(new GetAllShopsQuery());
            var mapped = this.mapper.Map<List<Shop>>(shops);
            return new GetAllShopsResponse() { Data = mapped.ToList() };
        }
    }
}
