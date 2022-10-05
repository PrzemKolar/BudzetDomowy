using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Validators
{
    public class AddAccountRequestValidator : AbstractValidator<AddAccountRequest>
    {
        public AddAccountRequestValidator()
        {
            this.RuleFor(x => x.Name).Length(1,100);
        }
    }
}
