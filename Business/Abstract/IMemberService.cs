using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMemberService
    {
        IResult Add(Member member);
        IResult Update(Member member);
        IResult Delete(Member member);
        IDataResult<List<Member>> GetAll();

    }
}
