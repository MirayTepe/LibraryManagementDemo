using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanedBooksController : ControllerBase
    {
        ILoanedBookService _loanedBookService;
        public LoanedBooksController(ILoanedBookService loanedBookService)
        {
            _loanedBookService = loanedBookService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll( )
        {
            var result = _loanedBookService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(LoanedBook loanedBook)
        {
            var result = _loanedBookService.Add(loanedBook);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
        [HttpPost("delete")]
        public IActionResult Delete(LoanedBook loanedBook)
        {
            var result = _loanedBookService.Delete(loanedBook);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
        [HttpPost("update")]
        public IActionResult Update(LoanedBook loanedBook)
        {
            var result = _loanedBookService.Update(loanedBook);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
    }
}
