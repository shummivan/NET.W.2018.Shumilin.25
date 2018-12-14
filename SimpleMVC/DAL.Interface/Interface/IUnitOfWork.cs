using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace DAL.Interface.Interface
{
    public interface IUnitOfWork
    {
        IRepository<DalAccount> Accounts { get; }
    }
}
