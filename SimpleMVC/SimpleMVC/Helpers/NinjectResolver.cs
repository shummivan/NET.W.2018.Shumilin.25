using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyResolver;

namespace SimpleMVC.Helpers
{
    public class NinjectResolver
    {
        private IKernel kernel;

        public NinjectResolver(IKernel kernel)
        {
            this.kernel = kernel;
            kernel.ConfigurateResolver();
        }
    }
}