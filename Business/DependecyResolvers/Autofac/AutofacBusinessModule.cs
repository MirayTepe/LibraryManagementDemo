using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<AdminManager>().As<IAdminService>().SingleInstance();
           builder.RegisterType<EfAdminDal>().As<IAdminDal>().SingleInstance();

           builder.RegisterType<BookManager>().As<IBookService>().SingleInstance();
           builder.RegisterType<EfBookDal>().As<IBookDal>().SingleInstance();

           builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
           builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

           builder.RegisterType<LoanedBookManager>().As<ILoanedBookService>().SingleInstance();
           builder.RegisterType<EfLoanedBookDal>().As< ILoanedBookDal>().SingleInstance();

           builder.RegisterType<MemberManager>().As<IMemberService>().SingleInstance();
           builder.RegisterType<EfMemberDal>().As<IMemberDal>().SingleInstance();

           builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
           builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
