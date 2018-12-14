using BLL.Interface.Entities;
using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM;

namespace DAL.Mappers
{
    public static class RepositoryMapper
    {
        public static ORM.Account Map(DalAccount acc)
        {
            return new ORM.Account()
            {
                Id = acc.Id,
                Balance = acc.Balance,
                BonusPoints = acc.BonusPoints
            };
        }

        public static DalAccount Map(ORM.Account acc)
        {
            return new DalAccount()
            {
                Id = acc.Id,
                Balance = acc.Balance,
                BonusPoints = acc.BonusPoints
            };
        }

        public static IEnumerable<DalAccount> Map(IQueryable<ORM.Account> queryable)
        {
            var result = new List<DalAccount>();
            foreach (var item in queryable)
            {
                result.Add(Map(item));
            }

            return result;
        }
    }
}
