using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Mappers
{
    public class AccountMapper : EntityTypeConfiguration<Account>
    {
        public AccountMapper()
        {
            ToTable("Accounts");

            HasKey(t => t.Id);
            Property(t => t.Balance).IsRequired();
            Property(t => t.BonusPoints).IsRequired();
        }
    }
}
