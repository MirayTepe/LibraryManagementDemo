using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.UserId).NotEmpty();
            RuleFor(m => m.MemberNumber).NotEmpty();
            RuleFor(m => m.MemberPhoneNumber).NotEmpty();
            RuleFor(m => m.MemberAdress).NotEmpty();
        }
    }
}
