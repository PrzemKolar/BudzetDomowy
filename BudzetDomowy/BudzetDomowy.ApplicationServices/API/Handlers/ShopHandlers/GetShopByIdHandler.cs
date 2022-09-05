using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Queries.ShopQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Handlers.ShopHandlers
{
    public class GetShopByIdHandler : IRequestHandler<GetShopByIdRequest, GetShopByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetShopByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetShopByIdResponse> Handle(GetShopByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetShopByIdQuery() { ShopId = request.ShopId };
            var ShopFromDB = await this.queryExecutor.Execute(query);
            return new GetShopByIdResponse() { Data = this.mapper.Map<Shop>(ShopFromDB) };
        }
    }
}
