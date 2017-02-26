using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test.Ninject
{
    public abstract class DependencyInjectedTestOffline
    {
        protected DependencyInjectedTestOffline()
        {
            Kernel = new StandardKernel(new NinjectConfigOffline());
        }

        protected IKernel Kernel { get; }
    }
}
