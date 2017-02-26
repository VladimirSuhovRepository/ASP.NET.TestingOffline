using Ninject.Modules;
using Project.BL.Interfaces;
using Project.BL.Providers;
using Project.DAL.Implementation;
using Project.DAL.Interface;
using Project.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Web.Common;

namespace Project.Test.Ninject
{
    public class NinjectConfigOffline : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            Bind<DbContext>().To<EntityModelOffline>().InRequestScope();

            Bind<IUsersProvider>().To<UsersProvider>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
