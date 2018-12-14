using BLL.Interface.Entities;
using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class ServiceMapper
    {
        public static Account Map(DalAccount acc)
        {
            return new Account()
            {
                Id = acc.Id,
                Balance = acc.Balance,
                BonusPoints = acc.BonusPoints
            };
        }
        public static DalAccount Map(Account acc)
        {
            return new DalAccount()
            {
                Id = acc.Id,
                Balance = acc.Balance,
                BonusPoints = acc.BonusPoints
            };
        }
        public static IEnumerable<Account> Map(IEnumerable<DalAccount> users)
        {
            var bllUsers = new List<Account>();
            foreach (var item in users)
            {
                bllUsers.Add(Map(item));
            }
            return bllUsers;
        }
    }
}
