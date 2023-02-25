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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MemberManager:IMemberService
    {
        IMemberDal _memberDal;
        public MemberManager(IMemberDal memberDal) { 
         
            _memberDal = memberDal; 
        }
        [ValidationAspect(typeof(MemberValidator))]
        public IResult Add(Member member)
        {
           IResult result=  BusinessRules.Run(CheckIfPhoneNumberExists(member.MemberPhoneNumber),CheckIfMemberNumberExists(member.MemberNumber));
            if (result!=null)
            {
                return result;
            }
           _memberDal.Add(member);
           return new SuccessResult(MemberMessages.MemberAdded);
        }

        public IResult Delete(Member member)
        {
            _memberDal.Delete(member);
            return new SuccessResult(MemberMessages.MemberDeleted);
        }
        public IResult Update(Member member)
        {
            _memberDal.Update(member);
            return new SuccessResult(MemberMessages.MemberUpdated);
        }

        public IDataResult<List<Member>> GetAll()
        {
            return new SuccessDataResult<List<Member>>(_memberDal.GetAll(),MemberMessages.MemberListed);
        }

        private IResult CheckIfPhoneNumberExists(string phoneNumber)
        {
            var result = _memberDal.GetAll(m => m.MemberPhoneNumber == phoneNumber).Any();
            if (result)
            {
                return new ErrorResult(MemberMessages.UniquePhoneNumber);
            }
            return new SuccessResult();
        }
        private IResult CheckIfMemberNumberExists(string memberNumber)
        {
            var result = _memberDal.GetAll(m => m.MemberNumber == memberNumber).Any();
            if (result)
            {
                return new ErrorResult(MemberMessages.UniquePhoneNumber);
            }
            return new SuccessResult();
        }

    }
}
