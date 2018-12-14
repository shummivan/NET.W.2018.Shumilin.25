using DAL;
using DAL.Interface.Interface;
using Ninject;
using ORM;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Interface.Interface;
using DAL.Interface.DTO;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IService>().To<Service>();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<DbContext>().To<SimpleDBContext>();
            kernel.Bind<IRepository<DalAccount>>().To<Repository>();
        }
    }
}
