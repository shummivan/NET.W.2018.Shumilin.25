using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Interface
{
    public interface IRepository<T> where T: class
    {
        T GetAccount(int id);
        void AddAccount(T acc);
        void UpdateAccount(T acc);
        void RemoveAccount(int id);
        IEnumerable<T> GetAll();
    }
}
