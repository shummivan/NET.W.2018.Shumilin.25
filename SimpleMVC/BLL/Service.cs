using BLL.Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using DAL.Interface.Interface;
using BLL.Mappers;
using DAL.Interface.DTO;

namespace BLL
{
    public class Service : IService
    {
        private readonly IUnitOfWork unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return ServiceMapper.Map(unitOfWork.Accounts.GetAll());
        }

        public Account GetBrand(int id)
        {
            return ServiceMapper.Map(unitOfWork.Accounts.GetAccount(id));
        }

        /// <summary>
        /// Deposit money 
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="money">Money</param>
        public void DepositAccount(int id, decimal money)
        {
            var account = ServiceMapper.Map(unitOfWork.Accounts.GetAccount(id));
            if (money <= 0 || account == null)
            {
                throw new ArgumentException();
            }
            account.Balance += money;


            //////
            account.BonusPoints += BonusPoints.GetBonusPoints("gold", money);
            /////
            unitOfWork.Accounts.UpdateAccount(ServiceMapper.Map(account));
        }

        /// <summary>
        /// Withdraw money
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="money">Money</param>
        public void WithdrawAccount(int id, decimal money)
        {
            var account = ServiceMapper.Map(unitOfWork.Accounts.GetAccount(id));
            if (money <= 0 || account == null)
            {
                throw new ArgumentException();
            }
            account.Balance -= money;
            account.BonusPoints -= BonusPoints.GetBonusPoints("gold", money);
            unitOfWork.Accounts.UpdateAccount(ServiceMapper.Map(account));
        }

        /// <summary>
        /// Open account
        /// </summary>
        /// <param name="v">name</param>
        /// <param name="base">type</param>
        /// <param name="id">id</param>
        public void OpenAccount(decimal balance, decimal bonus, int id)
        {
            Account acc = new Account()
            {
                Id = id,
                Balance = balance,
                BonusPoints = bonus
            };
            unitOfWork.Accounts.AddAccount(ServiceMapper.Map(acc));
            ///to-do
        }
    }
}
