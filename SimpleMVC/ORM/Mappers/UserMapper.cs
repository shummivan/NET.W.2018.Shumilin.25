using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Mappers
{
    public class UserMapper : EntityTypeConfiguration<User>
    {
        public UserMapper()
        {
            ToTable("Users");

            HasKey(t => t.Id);
            Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            Property(t => t.LastName).IsRequired().HasMaxLength(50);            
        }
    }
}
