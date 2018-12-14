﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BonusPoints
    {
        /// <summary>
        /// Calculate bonus points
        /// </summary>
        /// <param name="accountGradation">Account gradation</param>
        /// <param name="amount">Amount</param>
        /// <returns>Bonus points</returns>
        public static int GetBonusPoints(string accountGradation, decimal amount)
        {
            switch (accountGradation)
            {
                case "base":
                    amount = amount / 100;
                    return (int)amount;
                case "gold":
                    amount = amount / 100 * 2;
                    return (int)amount;
                case "platinum":
                    amount = amount / 100 * 4;
                    return (int)amount;
            }
            return (int)amount;
        }
    }
}
