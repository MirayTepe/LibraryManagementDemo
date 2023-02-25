using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.CategoryId).NotEmpty();
            RuleFor(b => b.BookName).NotEmpty();
            RuleFor(b => b.BookCount).NotEmpty();
            RuleFor(b => b.BookAuthor).NotEmpty();
            RuleFor(b => b.BookNumberOfPage).NotEmpty();
            RuleFor(b => b.BookPublisher).NotEmpty();
            RuleFor(b => b.BookDescription).NotEmpty();
            RuleFor(b => b.BookLanguage).NotEmpty();


        }
    }
}
