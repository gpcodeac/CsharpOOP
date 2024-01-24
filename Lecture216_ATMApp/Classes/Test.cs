
namespace Lecture216_ATMApp.Classes
{
    public class AccountTest
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public CustomerTest Owner { get; set; } // Reference to Customer

        // Other properties and methods related to the Account class

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Balance: {Balance:C}, Owner: {Owner?.Name}";
        }
    }

    public class CustomerTest
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public List<AccountTest> Accounts { get; set; } = new List<AccountTest>();

        // Other properties and methods related to the Customer class

        public void AddAccount(AccountTest account)
        {
            account.Owner = this; // Setting the reference to the customer
            Accounts.Add(account);
        }

        public override string ToString()
        {
            return $"Customer ID: {CustomerId}, Name: {Name}, Number of Accounts: {Accounts.Count}";
        }
    }

    class ProgramTest
    {
        static void MainTest()
        {
            // Creating an account
            AccountTest account1 = new AccountTest { AccountNumber = 123456, Balance = 1000.00M };

            // Creating a customer and associating the account with the customer
            CustomerTest customer1 = new CustomerTest { CustomerId = "C123", Name = "John Doe" };
            customer1.AddAccount(account1);

            // Accessing the account from the customer and vice versa
            Console.WriteLine(customer1); // Output: Customer ID: C123, Name: John Doe, Number of Accounts: 1
            Console.WriteLine(customer1.Accounts[0]); // Output: Account Number: 123456, Balance: $1,000.00, Owner: John Doe
            Console.WriteLine(account1.Owner); // Output: Customer ID: C123, Name: John Doe, Number of Accounts: 1
        }
    }

}


