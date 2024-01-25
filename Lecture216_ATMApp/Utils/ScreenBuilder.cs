using Lecture216_ATMApp.Classes;

namespace Lecture216_ATMApp.Utils
{
    internal static class ScreenBuilder
    {
        public static string InsertCardScreen(List<Card> cards)
        {
            string text = "Hello. Please insert the card.\n\n";
            for (int i = 0; i < cards.Count; i++)
            {
                text += i + 1 + ". " + cards[i].Guid + '\n';
            }
            text = text + "\nOption: ";
            return text;
        }

        public static string EnterPINScreen()
        {
            string text = "Please enter the PIN: ";
            return text;
        }

        public static string EjectingCardScreen()
        {
            string text = "Ejecting the card...";
            return text;
        }

        public static string CardBlockedScreen()
        {
            string text = "The card is blocked. Please contact the bank.";
            return text;
        }

        public static string CardExpiredScreen()
        {
            string text = "The card is expired. Please contact the bank.";
            return text;
        }

        public static string BlockingTheCardScreen()
        {
            string text = "Card is now blocked, because wrong PIN was entered 3 times.";
            return text;
        }

        public static string MainMenuScreen()
        {
            string text = """
                1. Remaining Balance
                2. Last Transactions
                3. Withdraw
                4. Deposit
                5. Exit
                
                Option: 
                """;
            return text;
        }

        public static string WithdrawScreen()
        {
            string text = "Please enter the amount you want to withdraw: ";
            return text;
        }

        public static string DepositScreen()
        {
            string text = "Please enter the bank notes you want to deposit: ";
            return text;
        }

        public static string RecentTransactionsScreen(List<string> transactions)
        {
            string text = "The last 5 transactions:\n\n" + string.Join("\n", transactions);
            return text;
        }

        public static void Display(this string text, ErrCode code = ErrCode.OK, bool hold = false)
        {
            Console.Clear();
            switch (code)
            {
                case ErrCode.OK:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case ErrCode.Information:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case ErrCode.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case ErrCode.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ErrCode.Fatal:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            if (hold)
            {
                Console.ReadLine();
            }
        }

    }
}
