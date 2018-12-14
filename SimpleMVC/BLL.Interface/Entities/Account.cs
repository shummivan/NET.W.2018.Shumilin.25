using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class Account
    {
        public int Id { get; set; }
        //public virtual User Owner { get; set; }
        public decimal Balance { get; set; }
        public decimal BonusPoints { get; set; }
        public List<Account> Accounts { get; set; } 

        public Account()
        {
            Accounts = new List<Account>();
        }
    }
}
