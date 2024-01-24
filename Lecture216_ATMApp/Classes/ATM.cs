
using System.Text.Json;
using Lecture216_ATMApp.Utils;
using Lecture216_ATMApp.Classes;

namespace Lecture216_ATMApp.Classes
{
    internal class ATM
    {
        private List<Card> _cards;
        private List<Customer> _customers;
        private List<Account> _accounts;
        private Card? _insertedCard = null;
        

        public ATM()
        {
            Initialize();
        }

        private void Initialize()
        {
            var jsoncards = File.ReadAllText("AlmostDatabase/Cards.json");
            var cards = JsonSerializer.Deserialize<List<Card>>(jsoncards);
            var jsoncustomers = File.ReadAllText("AlmostDatabase/Customers.json");
            var customers = JsonSerializer.Deserialize<List<Customer>>(jsoncustomers);
            var jsonaccounts = File.ReadAllText("AlmostDatabase/Accounts.json");
            var accounts = JsonSerializer.Deserialize<List<Account>>(jsonaccounts);
            LinkObjects(cards, customers, accounts);
            _cards = cards;
            _customers = customers;
            _accounts = accounts;
        }

        private void LinkObjects(List<Card> cards, List<Customer> customers, List<Account> accounts)
        {
            foreach (var card in cards)
            {
                accounts.Find(x => x.AccountNumber == card.AccountNumber).Cards.Add(card);
                card.Account = accounts.Find(x => x.AccountNumber == card.AccountNumber);
            }

            foreach (var account in accounts)
            {
                customers.Find(x => x.PersonalID == account.Owner).Accounts.Add(account);
                account.Customer = customers.Find(x => x.PersonalID == account.Owner);
            }
        }

        public void TestPrint()
        {
            foreach (var customer in _customers)
            {
                customer.PrintAll();
                Console.WriteLine();
            }
            foreach (var account in _accounts)
            {
                account.PrintAll();
                Console.WriteLine();
            }
            foreach (var card in _cards)
            {
                card.PrintAll();
                Console.WriteLine();
            }
        }


        private void ReadCard()
        {
            if (int.TryParse(Console.ReadLine(), out var option) && option > 0 && option <= _cards.Count)
            {
                _insertedCard = _cards[option];
            }
            else
            {
                throw new Exception("Invalid option");
            }
        }


        public void Run()
        {
            while (_insertedCard is null)
            {
                ScreenBuilder.BuildInsertCardScreen(_cards).Display();
                try
                {
                    ReadCard();
                }
                catch (Exception e)
                {
                    Console.Clear();
                    (e.Message + "\n\n\n").Display(ErrCode.Error);
                }
            }

        }

        

        public void CheckPin()
        {

        }

       

        

        //the card is put in the ATM
        //the card is read, guid compared
        //pin prompted, exit button should be available
        //pin is compared
        //if pin is correct, from card number, the account number is extracted - is this possible ? how to link back form card to account?
        //account number is saved locally during the "operation" and is used to do further operations
        //menu to withdraw, deposit, see balance, see trans history exit
        //validations to check if no cents for withdrawal or deposit, etc
        //add transactions to hist when executing



    }
}
