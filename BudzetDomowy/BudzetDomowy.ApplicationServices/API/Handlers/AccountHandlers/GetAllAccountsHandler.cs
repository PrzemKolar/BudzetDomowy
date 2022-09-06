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
    public class GetAllAccountsHandler : IRequestHandler<GetAllAccountsRequest,GetAllAccountsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetAllAccountsHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetAllAccountsResponse> Handle(GetAllAccountsRequest request, CancellationToken cancellationToken)
        {
            var accountsFromDB = await this.queryExecutor.Execute(new GetAllAccountsQuery());
            var mapped = this.mapper.Map<List<Account>>(accountsFromDB);
            return new GetAllAccountsResponse() { Data = mapped.ToList() };
        }
    }
}
