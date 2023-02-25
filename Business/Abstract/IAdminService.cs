using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        IResult Add(Admin admin);
        IResult Update(Admin admin);
        IResult Delete(Admin admin);
        IDataResult<List<Admin>> GetAll();
     


    }
}
