using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;

namespace BLL.Interface.Interface
{
    public interface IService
    {
        void DepositAccount(int id, decimal money);
        void WithdrawAccount(int id, decimal money);
        IEnumerable<Account> GetAllAccounts();
        void OpenAccount(decimal balance, decimal bonus, int id);
    }
}
