
using System.Runtime.CompilerServices;

namespace Lecture216_ATMApp.Classes
{
    internal class AccountStatement
    {
        public AccountStatement(string accountNumber)
        {
            AccountNumber = accountNumber;
            string path = "AlmostDatabase/Transactions.txt";
            List<string> lines = File.ReadAllLines(path).ToList();
            Transactions = lines.Where(x => x.Split(',').Contains(accountNumber))
                                .OrderByDescending(x => x.Split(',')[2])
                                .ToList();
            CreationTime = DateTime.Now;
        }

        //public AccountStatement(string accountNumber, DateOnly dateFrom, DateOnly? dateUntil)
        //{
        //    AccountNumber = accountNumber;
        //    if (dateUntil is null)
        //    {
        //        dateUntil = DateOnly.FromDateTime(DateTime.Today);
        //    }
        //    string path = "AlmostDatabase/Transactions.txt";
        //    List<string> lines = File.ReadAllLines(path).ToList();
        //    Transactions = lines.Where(x => x.Split(',').Contains(accountNumber)
        //                                    && DateOnly.Parse(x.Split(',')[2]) >= dateFrom
        //                                    && DateOnly.Parse(x.Split(',')[2]) <= dateUntil)
        //                        .OrderByDescending(x => x.Split(',')[2])
        //                        .ToList();
        //    CreationTime = DateTime.Now;
        //}


        private List<string> Transactions { get; set; }
        private string AccountNumber { get; set; }
        private DateTime CreationTime { get; set; }


        public void Save()
        {
            string path = $"{AccountNumber}_statement_{CreationTime}.txt";
            File.WriteAllLines(path, Transactions);
        }

        public List<string> GetTransactions(int count)
        {
            return Transactions.Take(count).ToList();
        }

        public List<string> GetTransactions(DateOnly dateFrom, DateOnly? dateUntil)
        {
            if (dateUntil is null)
            {
                dateUntil = DateOnly.FromDateTime(DateTime.Today);
            }
            return Transactions.Where(x => DateOnly.Parse(x.Split(',')[2]) >= dateFrom && DateOnly.Parse(x.Split(',')[2]) <= dateUntil).ToList();
        }

        public void Print()
        {
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }

        public override string ToString()
        {
            return Transactions.ToString();
        }

    }
}
