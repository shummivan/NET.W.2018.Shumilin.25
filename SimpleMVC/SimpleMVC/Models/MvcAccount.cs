using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleMVC.Helpers;

namespace SimpleMVC.Models
{
    public class MvcAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal BonusPoints { get; set; }
        public int IdUser { get; set; }
        public virtual MvcUser User { get; set; }
        public List<MvcAccount> Accounts { get; set; }

        public MvcAccount()
        {
            Accounts = new List<MvcAccount>();
        }
    }
}
