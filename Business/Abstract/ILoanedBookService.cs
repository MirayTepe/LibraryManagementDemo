using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILoanedBookService
    {
        IResult Add(LoanedBook loanedBook);
        IResult Delete(LoanedBook loanedBook);

        IResult Update(LoanedBook loanedBook);
        IDataResult<List<LoanedBook>> GetAll();
        IDataResult<LoanedBook> GetById(int id);
        IDataResult<List<LoanedBook>> GetAllByMemberId(int id);
    }
}
