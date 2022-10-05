using BudzetDomowy.ApplicationServices.API.Domain.ShopRequestsResponses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Validators
{
    public class AddShopRequestValidator : AbstractValidator<AddShopRequest>
    {
        public AddShopRequestValidator()
        {
            this.RuleFor(x => x.Name).Length(2, 30);
            this.RuleFor(x => x.Logo).Length(5, 20);
        }
    }
}
