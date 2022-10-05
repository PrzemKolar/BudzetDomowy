using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.DataAccess.CQRS;
using BudzetDomowy.DataAccess.CQRS.Queries.AccountQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Handlers.AccountHandlers
{
    public class GetAccountByIdHandler : IRequestHandler<GetAccountByIdRequest, GetAccountByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetAccountByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetAccountByIdResponse> Handle(GetAccountByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetAccountByIdQuery() { AccountId = request.AccountId };
            var accoutFromDB = await this.queryExecutor.Execute(query);
            return new GetAccountByIdResponse() { Data = this.mapper.Map<Account>(accoutFromDB) };

        }
    }
}
