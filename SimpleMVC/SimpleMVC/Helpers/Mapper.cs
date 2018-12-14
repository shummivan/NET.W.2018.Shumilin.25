using BLL.Interface.Entities;
using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Helpers
{
    public static class Mapper
    {
        public static Account Map(MvcAccount acc)
        {
            return new Account()
            {
                Id = acc.Id,
                Balance = acc.Balance,
                BonusPoints = acc.BonusPoints
            };
        }

        public static MvcAccount Map(Account acc)
        {
            return new MvcAccount()
            {
                Id = acc.Id,
                Balance = acc.Balance,
                BonusPoints = acc.BonusPoints
            };
        }

        public static IEnumerable<MvcAccount> Map(IEnumerable<Account> categories)
        {
            var result = new List<MvcAccount>();
            foreach (var item in categories)
            {
                result.Add(Map(item));
            }

            return result;
        }

        public static IEnumerable<Account> Map(IEnumerable<MvcAccount> categories)
        {
            var result = new List<Account>();
            foreach (var item in categories)
            {
                result.Add(Map(item));
            }

            return result;
        }
    }
}