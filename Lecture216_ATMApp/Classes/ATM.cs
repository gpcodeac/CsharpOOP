
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


        private void ChooseCard()
        {
            Console.Clear();
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
                    (e.Message + "\n\n").Display(ErrCode.Error);
                }
            }
        }

        private void ReadCard()
        {
            if (int.TryParse(Console.ReadLine(), out var option) && option > 0 && option <= _cards.Count)
            {
                _insertedCard = _cards[option - 1];
            }
            else
            {
                throw new Exception("Invalid option");
            }
        }

        private void CheckPin()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                ScreenBuilder.BuildEnterPINScreen().Display();
                if (Console.ReadLine() != _insertedCard.Pin)
                {
                    Console.Clear();
                    ("Invalid PIN\n\n").Display(ErrCode.Error);
                }
                else
                {
                    return;
                }

                if (i == 2)
                {
                    BlockCard();
                }
            }
        }

        private void BlockCard()
        {
            _insertedCard.CardStatus = CardStatusOptions.Blocked;
            ("Card blocked, because wrong PIN was entered 3 times.\n\n").Display(ErrCode.Error);
            Console.ReadLine();
        }


        private bool CardBlocked()
        {
            if (_insertedCard.CardStatus == CardStatusOptions.Blocked)
            {
                return true;
            }
            return false;
        }

        private void MainMenu()
        {
            Console.Clear();
            while (true)
            {
                ScreenBuilder.BuildMainMenuScreen().Display();
                if (int.TryParse(Console.ReadLine(), out var option) && option > 0 && option <= 5)
                {
                    switch (option)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            Withdraw();
                            break;
                        case 3:
                            Deposit();
                            break;
                        case 4:
                            Exit();
                            return;
                    }
                }
                else
                {
                    Console.Clear();
                    ("Invalid option\n\n").Display(ErrCode.Error);
                }
            }
        }


        private void CheckBalance()
        {
            Console.Clear();
            ("Your balance is: " + _insertedCard.Account.Balance + "\n\n").Display(ErrCode.Information);
        }

        public void Withdraw()
        {

        }

        public void Deposit()
        {

        }



        private void Exit()
        {
            Console.Clear();
            ScreenBuilder.EjectingCardScreen().Display(ErrCode.Information);
            _insertedCard = null;

            SaveToDb();
            Console.ReadLine();
        }

        private void SaveToDb()
        {
            var jsoncards = JsonSerializer.Serialize(_cards);
            File.WriteAllText("AlmostDatabase/Cards.json", jsoncards);
            var jsoncustomers = JsonSerializer.Serialize(_customers);
            File.WriteAllText("AlmostDatabase/Customers.json", jsoncustomers);
            var jsonaccounts = JsonSerializer.Serialize(_accounts);
            File.WriteAllText("AlmostDatabase/Accounts.json", jsonaccounts);
        }


        public void Run()
        {
            ChooseCard();
            CheckPin();
            if (CardBlocked())
            {
                Exit();
                return;
            }
            MainMenu();
        }









        //DONE: the card is put in the ATM
        //DONE: the card is read, guid compared
        //DONE: pin prompted
        //DONE :pin is compared
        //exit button should be available in PIN menu
        //NOT NEEDED: if pin is correct, from card number, the account number is extracted - is this possible ? how to link back form card to account?
        //NOT NEEDED: account number is saved locally during the "operation" and is used to do further operations
        //menu to withdraw, deposit, see balance, see trans history exit
        //validations to check if no cents for withdrawal or deposit, etc
        //add transactions to hist when executing



    }
}
