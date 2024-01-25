using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture216_ATMApp.Classes;

namespace Lecture216_ATMApp.Utils
{
    internal static class Validations
    {
        public static void WithdrawValidations(decimal amount, Account account)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than 0.");
            }

            if (amount % 10 != 0)
            {
                throw new ArgumentException("Amount must be divisible by 10.");
            }

            if (amount > account.Balance)
            {
                throw new ArgumentException("Not enough balance on the account.");
            }

            if (amount > 1000)
            {
                throw new ArgumentException("Amount should be up to 1000.");
            }

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            if (account.GetAccountStatement().GetTransactions(today, today).Where(x => decimal.Parse(x.Split(',')[1]) < 0).ToList().Count > 10)
            {
                throw new ArgumentException("You have reached the limit of 10 transactions per day.");
            }
        }
    }
}
