using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Mappings
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            this.CreateMap<DataAccess.Entities.Account, Account>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Value, y => y.MapFrom(z => z.Value));

            this.CreateMap<AddAccountRequest, DataAccess.Entities.Account>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
