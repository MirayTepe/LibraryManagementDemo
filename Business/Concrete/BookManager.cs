using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(BookMessages.BookAdded);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(BookMessages.BookDeleted);
        }
        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(BookMessages.BookUpdated);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), BookMessages.BookListed);
        }

        public IDataResult<List<Book>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(p => p.BookId == bookId));
        }
    }
}
