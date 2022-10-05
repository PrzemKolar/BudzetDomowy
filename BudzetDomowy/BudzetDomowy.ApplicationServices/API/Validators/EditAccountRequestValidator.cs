using BudzetDomowy.ApplicationServices.API.Domain.AccountRequestsResponses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Validators
{
    public class EditAccountRequestValidator : AbstractValidator<EditAccountRequest>
    {
        public EditAccountRequestValidator()
        {
            this.RuleFor(x => x.Name).Length(1, 100);
        }

    }
}
