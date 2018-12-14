using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interface.DTO
{
    public class DalAccount
    {
        public int Id { get; set; }
        //public virtual DalUser Owner { get; set; }
        public decimal Balance { get; set; }
        public decimal BonusPoints { get; set; }
        public List<DalAccount> Accounts { get; set; }

        public DalAccount()
        {
            Accounts = new List<DalAccount>();
        }
    }
}
