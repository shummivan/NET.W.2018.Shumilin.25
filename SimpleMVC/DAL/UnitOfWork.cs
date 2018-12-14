using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Interface;
using ORM;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; private set; }
        private Repository rep;
        public IRepository<DalAccount> Accounts { get; private set; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
            Accounts = new Repository((SimpleDBContext) context);
        }
    }
}
