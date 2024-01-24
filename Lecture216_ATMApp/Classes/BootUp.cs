using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lecture216_ATMApp.Classes
{
    internal static class BootUp
    {
        public static void LoadData()
        {
            //var jsoncards = File.ReadAllText("AlmostDatabase/Cards.json");
            //var cards = JsonSerializer.Deserialize<List<Card>>(jsoncards);
            //var GUIDs = cards.Select(x => x.Guid).ToList();
            //GUIDs.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();

            //var jsoncustomers = File.ReadAllText("AlmostDatabase/Customers.json");
            //var customers = JsonSerializer.Deserialize<List<Customer>>(jsoncustomers);
            //var PIDs = customers.Select(x => x.PersonalID).ToList();
            //PIDs.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();
            //var DOBs = customers.Select(x => x.DateOfBirth).ToList();
            //DOBs.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();

            //var jsonaccounts = File.ReadAllText("AlmostDatabase/Accounts.json");
            //var accounts = JsonSerializer.Deserialize<List<Account>>(jsonaccounts);
            //var accNumbers = accounts.Select(x => x.AccountNumber).ToList();
            //accNumbers.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();

            var jsoncards = File.ReadAllText("AlmostDatabase/Cards.json");
            var cards = JsonSerializer.Deserialize<List<Card>>(jsoncards);
            var jsoncustomers = File.ReadAllText("AlmostDatabase/Customers.json");
            var customers = JsonSerializer.Deserialize<List<Customer>>(jsoncustomers);
            var jsonaccounts = File.ReadAllText("AlmostDatabase/Accounts.json");
            var accounts = JsonSerializer.Deserialize<List<Account>>(jsonaccounts);
        }

        public static void LinkObjects()
        {

        }
    }
}
