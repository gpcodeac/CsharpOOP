
using System.Text.Json.Serialization;

namespace Lecture216_ATMApp.Classes
{
    internal class Customer
    {
        
        //private List<Account> _accounts;

        
        [JsonConstructor]
        public Customer(string name, string surname, string personalID, DateOnly dateOfBirth, string address, string occupation = "", bool maritalStatus = false)
        {
            Name = name;
            Surname = surname;
            PersonalID = personalID;
            DateOfBirth = dateOfBirth;
            Address = address;
            Occupation = occupation;
            MaritalStatus = maritalStatus;
        }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        [JsonPropertyName("PID")]
        public string PersonalID { get; set; }  

        [JsonPropertyName("DOB")]
        public DateOnly DateOfBirth { get; set; }
        
        public string Address { get; set; }

        public string Occupation { get; set; }

        public bool MaritalStatus { get; set; }

        [JsonIgnore]
        public List<Account> Accounts { get; set; } = new List<Account>();


        public override string ToString()
        {
            return $"{Name} {Surname} {PersonalID} {DateOfBirth} {Address} {Occupation} {MaritalStatus}";
        }

        public void PrintAll()
        {
            Console.WriteLine($"{Name} {Surname} {PersonalID} {DateOfBirth} {Address} {Occupation} {MaritalStatus}");
            foreach (var account in Accounts)
            {
                Console.WriteLine($"{account.AccountNumber} {account.Balance}");
            }
        }
    }
}
