using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(a => a.UserId).NotEmpty();
            RuleFor(a => a.AdminUserName).NotEmpty();
            RuleFor(a => a.AdminUserName).MinimumLength(2);

        }
    }
}
