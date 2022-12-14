using AutoMapper;
using BudzetDomowy.ApplicationServices.API.Domain.Models;
using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Mappings
{
    public class ShopsProfile : Profile
    {
        public ShopsProfile()
        {
            this.CreateMap<DataAccess.Entities.Shop, Shop>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Logo, y => y.MapFrom(z => z.Logo));

            this.CreateMap<AddShopRequest, DataAccess.Entities.Shop>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Logo, y => y.MapFrom(z => z.Logo));

            this.CreateMap<EditShopRequest, DataAccess.Entities.Shop>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Logo, y => y.MapFrom(z => z.Logo));
        }
    }
}
