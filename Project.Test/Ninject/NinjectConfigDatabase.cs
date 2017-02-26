using Ninject.Modules;
using Project.BL.Providers;
using Project.DAL.Implementation;
using Project.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Web.Common;
using Project.ORM;
using Project.BL.Interfaces;

namespace Project.Test.Ninject
{
    public class NinjectConfigDatabase : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            Bind<DbContext>().To<EntityModelDatabase>().InRequestScope();

            Bind<IUsersProvider>().To<UsersProvider>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
