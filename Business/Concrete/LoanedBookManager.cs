using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LoanedBookManager : ILoanedBookService
    {
        ILoanedBookDal _loanedBookDal;
        public LoanedBookManager(ILoanedBookDal loanedBookDal)
        {
            _loanedBookDal = loanedBookDal;
        }

        [ValidationAspect(typeof(LoanedBookValidator))]
        public IResult Add(LoanedBook loanedBook)
        {
          IResult result= BusinessRules.Run(CheckIfLoanedBookCountCorrect(loanedBook.MemberId));
            if (result!=null)
            {
                return result;
            }
          _loanedBookDal.Add(loanedBook);
          return new SuccessResult(LoanedBookMessages.LoanedBookAdded);
        }

        public IResult Delete(LoanedBook loanedBook)
        {
            _loanedBookDal.Delete(loanedBook);
            return new SuccessResult(LoanedBookMessages.LoanedBookDeleted);
        }
        public IResult Update(LoanedBook loanedBook)
        {
            _loanedBookDal.Update(loanedBook);
            return new SuccessResult(LoanedBookMessages.LoanedBookUpdate);
        }

        public IDataResult<List<LoanedBook>> GetAll()
        {
            return new SuccessDataResult<List<LoanedBook>>(_loanedBookDal.GetAll(), LoanedBookMessages.LoanedBookListed);
        }

        public IDataResult<List<LoanedBook>> GetAllByMemberId(int id)
        {
            return new SuccessDataResult<List<LoanedBook>>(_loanedBookDal.GetAll(p => p.MemberId == id));
        }
        public IDataResult<LoanedBook> GetById(int id)
        {
            return new SuccessDataResult<LoanedBook>(_loanedBookDal.Get(p => p.LoanedBookId == id));
        }
        private IResult CheckIfLoanedBookCountCorrect(int memberId)
        {
            var result = _loanedBookDal.GetAll(m => m.MemberId == memberId).Count;
            if (result > 10)
            {
                return new ErrorResult(LoanedBookMessages.LoanedBookCount);
            }

            return new SuccessResult(LoanedBookMessages.LoanedBookAdded);
        }
    }



}
