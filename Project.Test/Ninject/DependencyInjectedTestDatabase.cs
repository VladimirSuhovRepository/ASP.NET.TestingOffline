using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test.Ninject
{
    public abstract class DependencyInjectedTestDatabase
    {
        protected DependencyInjectedTestDatabase()
        {
            Kernel = new StandardKernel(new NinjectConfigDatabase());
        }

        protected IKernel Kernel { get; }
    }
}
