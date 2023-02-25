using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        [ValidationAspect(typeof(AdminValidator))]
        public IResult Add(Admin admin)
        {
            ValidationTool.Validate(new AdminValidator(), admin);
            _adminDal.Add(admin);
            return new SuccessResult(AdminMessages.AdminAdded);
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(AdminMessages.AdminDeleted);
        }
        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(AdminMessages.AdminUpdated);
        }

        public IDataResult<List<Admin>> GetAll()
        {
            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll(), AdminMessages.AdminListed);
        }



    }
}
