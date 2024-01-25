
using System.Text.Json.Serialization;
using Lecture216_ATMApp.Utils;

namespace Lecture216_ATMApp.Classes
{
    internal class Account
    {
        //private Customer _customer;
        //private decimal _balance;
        //private string _accountNumber;
        //private List<Card> _cards;

        public Account(Customer customer)
        {
            Customer = customer;
            Customer.Accounts.Add(this);
            GenerateAccountNumber();
        }

        public Account(string customerName, string customerSurname, string customerPID, DateOnly customerDOB, string address)
        {
            Customer = new Customer(customerName, customerSurname, customerPID, customerDOB, address);
            Customer.Accounts.Add(this);
            GenerateAccountNumber();
        }

        [JsonConstructor]
        public Account(string accountNumber, decimal balance, string owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
        }


        [JsonPropertyName("IBAN")]
        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public string Owner { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonIgnore]
        public List<Card> Cards { get; set; } = new List<Card>();



        private void GenerateAccountNumber()
        {
            string path = "../../../AlmostDatabase/ValidIBANs.txt";
            string[] IBANs = File.ReadAllLines(path);
            AccountNumber = IBANs[0];
            File.WriteAllLines(path, IBANs.Skip(1).ToArray());
        }

        private void RecordTransaction(string accountNumber, decimal amount)
        {
            string path = "../../../AlmostDatabase/Transactions.txt";
            string line = string.Join(',', accountNumber, amount, DateTime.Now.ToString());
            File.AppendAllText(path, line + '\n');
            //using (StreamWriter sr = File.AppendText(path))
            //{
            //    sr.WriteLine(line);
            //} 
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            RecordTransaction(AccountNumber, amount);
        }

        public void Withdraw(decimal amount)
        {
            try
            {
                Validations.WithdrawValidations(amount, this);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            Balance -= amount;
            RecordTransaction(AccountNumber, -amount);
        }

        public void Transfer(decimal amount, Account destinationAccount) //maybe just use account number?
        {
            Balance -= amount;
            RecordTransaction(AccountNumber, -amount);
            destinationAccount.Balance += amount;
            RecordTransaction(destinationAccount.AccountNumber, amount);
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }

        public AccountStatement GetAccountStatement()
        {
            return new AccountStatement(AccountNumber);
        }

        public void AddCard()
        {
            Card card = new(this);
            Cards.Add(card);
        }





        public override string ToString()
        {
            return $"Account number: {AccountNumber}, Balance: {Balance}, Owner: {Customer.Name}";
        }

        public void PrintAll()
        {
            Console.WriteLine($"Account number: {AccountNumber}, Balance: {Balance}, Owner: {Customer.Name}");
            foreach (var card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
