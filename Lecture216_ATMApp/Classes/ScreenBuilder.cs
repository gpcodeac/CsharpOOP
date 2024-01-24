using Lecture216_ATMApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lecture216_ATMApp.Classes
{
    internal static class ScreenBuilder
    {
        public static string BuildInsertCardScreen()
        {
            string text = """
                Hello. Please enter the card.

                1. "2c5457cb-271c-4240-bad6-3157013dd8ab"
                2. "0b62c529-98fe-4c16-92f8-fd89794b6ec7"
                3. "8ffe9219-3201-46a7-8f3b-40eb84271932"
                4. "6974d626-dbe2-4419-9075-97a96a5778fa"
                5. "779d9d5b-b81a-4eae-aebe-eb7b90bf5f43"
                6. "99195c3d-c691-4457-a5fc-46f6de45cc1f"
                
                Option: 
                """;
            return text;
        }

        public static string BuildInsertCardScreen(List<Card> cards)
        {
            string text = "Hello. Please insert the card.\n\n";
            for (int i = 0; i < cards.Count; i++)
            {
                text += i+1 + ". " + cards[i].Guid + '\n';
            }
            text = text + "\nOption: ";
            return text;
        }

        public static string BuildEnterPINScreen()
        {
            string text = "Please enter the PIN: ";
            return text;
        }

        public static string EjectingCardScreen()
        {
            string text = "Ejecting the card...";
            return text;
        }

        public static string BuildMainMenuScreen()
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

        public static void Display(this string text, ErrCode code = ErrCode.OK)
        {
            switch(code)
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
        }

    }
}
