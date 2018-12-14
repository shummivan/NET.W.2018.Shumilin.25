using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using System.Text;
using DAL.Interface.DTO;
using BLL.Mappers;
using ORM.Mappers;

namespace ORM
{
    public class SimpleDBContext : DbContext
    {
        public SimpleDBContext() :
            base("name=UserDBEntities")
        {
            Database.SetInitializer<SimpleDBContext>(null);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new UserMapper());
        }
    }
}
