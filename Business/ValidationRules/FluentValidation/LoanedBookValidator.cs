using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class LoanedBookValidator : AbstractValidator<LoanedBook>
    {
        public LoanedBookValidator()
        {
            RuleFor(l => l.MemberId).NotEmpty();
            RuleFor(l => l.BookId).NotEmpty();
            RuleFor(l => l.DateRetrieveBook).NotEmpty();
            RuleFor(l => l.DateRetrieveBook).NotEmpty();
            RuleFor(l => l.DateLaonedBookProcessing).NotEmpty();
            RuleFor(l => l.LoanedBookNot).NotEmpty();
            RuleFor(l => l.LoanedBookDelivery).NotEmpty();
        }
    }
}
