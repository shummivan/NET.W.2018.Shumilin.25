using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM;
using DAL.Interface.DTO;
using DAL.Interface.Interface;
using DAL.Mappers;

namespace DAL
{
    public class Repository : IRepository<DalAccount>
    {
        private readonly SimpleDBContext context;

        public Repository(SimpleDBContext context)
        {
            this.context = context;
        }

        public Repository()
        {
            this.context = new SimpleDBContext();
        }

        /// <summary>
        /// Get account
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Account</returns>
        public DalAccount GetAccount(int id)
        {
            return RepositoryMapper.Map(context.Accounts.Find(id));          
        }

        /// <summary>
        /// Get all accont
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable<DalAccount> GetAll()
        {
            var t = context.Set<Account>();
            return RepositoryMapper.Map(t.Select(p => p));
        }

        /// <summary>
        /// Add account
        /// </summary>
        /// <param name="acc">Account</param>
        public void AddAccount(DalAccount acc)
        {
            if (acc == null)
            {
                throw new ArgumentNullException();
            }
            context.Set<Account>().Add(RepositoryMapper.Map(acc));
            context.SaveChanges();
        }

        /// <summary>
        /// Remove account
        /// </summary>
        /// <param name="id">id</param>
        public void RemoveAccount(int id)
        {
            Account acc = RepositoryMapper.Map(GetAccount(id));

            if (acc != null)
            {
                context.Set<Account>().Remove(acc);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Update account
        /// </summary>
        /// <param name="acc">Account</param>
        public void UpdateAccount(DalAccount acc)
        {
            Account account = context.Accounts.First(p => p.Id == acc.Id);

            account.Id = acc.Id;
            account.Balance = acc.Balance;
            account.BonusPoints = acc.BonusPoints;
            context.SaveChanges();
        }
    }
}
