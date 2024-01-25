
using System.Text.Json;
using Lecture216_ATMApp.Utils;
using System.Xml;

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



        public void Run()
        {
            ChooseCard();
            if (CardExpired())
            {
                ScreenBuilder.CardExpiredScreen().Display(ErrCode.Warning, true);
                Exit();
                return;
            }
            else if (CardBlocked())
            {
                ScreenBuilder.CardBlockedScreen().Display(ErrCode.Warning, true);
                Exit();
                return;
            }

            CheckPin();
            if (CardBlocked())
            {
                Exit();
                return;
            }

            MainMenu();
        }



        private void ChooseCard()
        {
            while (_insertedCard is null)
            {
                ScreenBuilder.InsertCardScreen(_cards).Display();
                try
                {
                    ReadCard();
                }
                catch (Exception e)
                {
                    (e.Message + "\n\n").Display(ErrCode.Error, true);
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
            for (int i = 0; i < 3; i++)
            {
                ScreenBuilder.EnterPINScreen().Display();
                if (Console.ReadLine() != _insertedCard.Pin)
                {
                    ("Invalid PIN\n\n").Display(ErrCode.Error, true);
                }
                else
                {
                    return;
                }

                if (i == 2)
                {
                    _insertedCard.CardStatus = CardStatusOptions.Blocked;
                    ScreenBuilder.BlockingTheCardScreen().Display(ErrCode.Error, true);
                }
            }
        }

        private bool CardBlocked()
        {
            if (_insertedCard.CardStatus == CardStatusOptions.Blocked)
            {
                return true;
            }
            return false;
        }

        private bool CardExpired()
        {
            if (_insertedCard.ExpiryDate.CompareTo(DateOnly.FromDateTime(DateTime.Today)) == -1)
            {
                return true;
            }
            return false;
        }

        private void MainMenu()
        {
            while (true)
            {
                ScreenBuilder.MainMenuScreen().Display();
                if (int.TryParse(Console.ReadLine(), out var option) && option > 0 && option <= 5)
                {
                    switch (option)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            LastTransactions();
                            break;
                        case 3:
                            Withdraw();
                            break;
                        case 4:
                            Deposit();
                            break;
                        case 5:
                            Exit();
                            return;
                    }
                }
                else
                {
                    ("Invalid option\n\n").Display(ErrCode.Error, true);
                }
            }
        }

        private void CheckBalance()
        {
            ("Your balance is: " + _insertedCard.Account.Balance + "\n\n").Display(ErrCode.Information, true);
        }

        private void LastTransactions()
        {
            List<string> transactions = _insertedCard.Account.GetAccountStatement().GetTransactions(5);
            ScreenBuilder.RecentTransactionsScreen(transactions).Display(ErrCode.Information, true);
        }

        private void Withdraw()
        {
            ScreenBuilder.WithdrawScreen().Display();
            if (!decimal.TryParse(Console.ReadLine(), out var amount))
            {
                ("Invalid amount.\n\n").Display(ErrCode.Error, true);
                return;
            }

            try
            {
                _insertedCard.Account.Withdraw(amount);
            }
            catch (Exception e)
            {
                (e.Message + "\n\n").Display(ErrCode.Error, true);
                return;
            }

            ("Please take your money\n\n").Display(ErrCode.Information, true);
        }

        private void Deposit()
        {
            ScreenBuilder.DepositScreen().Display();
            string[] notes = Console.ReadLine().Replace(" ", "").Split(',');
            decimal amount = 0;
            foreach (var a in notes)
            {
                if (decimal.TryParse(a, out decimal note))
                {
                    amount += note;
                }
                else
                {
                    ("Unrecognised bank note.\n\n").Display(ErrCode.Error, true);
                    return;
                }
            }

            try
            {
                _insertedCard.Account.Deposit(amount);
            }
            catch (Exception e)
            {
                (e.Message + "\n\n").Display(ErrCode.Error, true);
                return;
            }

            ("Money deposited.\n\n").Display(ErrCode.Information, true);
        }

        private void Exit()
        {
            ScreenBuilder.EjectingCardScreen().Display(ErrCode.Information, true);
            _insertedCard = null;

            try
            {
                SaveToDb();
            }
            catch (Exception e)
            {
                (e.Message + "\n\n").Display(ErrCode.Error, true);
            }
        }

        private void SaveToDb()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsoncards = JsonSerializer.Serialize(_cards, options);
            File.WriteAllText("../../../AlmostDatabase/Cards.json", jsoncards);
            var jsoncustomers = JsonSerializer.Serialize(_customers, options);
            File.WriteAllText("../../../AlmostDatabase/Customers.json", jsoncustomers);
            var jsonaccounts = JsonSerializer.Serialize(_accounts, options);
            File.WriteAllText("../../../AlmostDatabase/Accounts.json", jsonaccounts);
        }





        //DONE: the card is put in the ATM
        //DONE: the card is read, guid compared
        //DONE: pin prompted
        //DONE :pin is compared
        //exit button should be available in PIN menu
        //NOT NEEDED: if pin is correct, from card number, the account number is extracted - is this possible ? how to link back form card to account?
        //NOT NEEDED: account number is saved locally during the "operation" and is used to do further operations
        //DONE: menu to withdraw, deposit, see balance, see trans history exit
        //DONE: validations to check if no cents for withdrawal or deposit, etc
        //DONE: add transactions to hist when executing

        private void Initialize()
        {
            var jsoncards = File.ReadAllText("../../../AlmostDatabase/Cards.json");
            var cards = JsonSerializer.Deserialize<List<Card>>(jsoncards);
            var jsoncustomers = File.ReadAllText("../../../AlmostDatabase/Customers.json");
            var customers = JsonSerializer.Deserialize<List<Customer>>(jsoncustomers);
            var jsonaccounts = File.ReadAllText("../../../AlmostDatabase/Accounts.json");
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

    }
}
