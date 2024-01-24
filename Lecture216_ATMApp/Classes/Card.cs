using Lecture216_ATMApp.Utils;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Lecture216_ATMApp.Classes
{
    internal class Card
    {

        //private Account _account;
        //private Guid _guid;
        //private string _pin;
        //private DateOnly _expiryDate;
        //private string _crcCode;
        //private string _cardNumber;
        //private CardStatusOptions _cardStatus;
        //private CardTypeOptions _cardType;

        public Card(Account account)
        {
            @Guid = Guid.NewGuid();
            Pin = new Random().Next(0, 10000).ToString("D4");
            ExpiryDate = DateOnly.FromDateTime(DateTime.Today.AddYears(5));
            CrcCode = new Random().Next(0, 1000).ToString("D3");
            CardNumber = "51639320" + new Random().Next(0, 100000000).ToString("D8");
            CardStatus = CardStatusOptions.Active;
            CardType = CardTypeOptions.MasterCard;
            AccountNumber = account.AccountNumber;
            Account = account;
        }

        [JsonConstructor]
        public Card(Guid guid, string pin, DateOnly expirydate, string crcCode, string cardNumber, CardStatusOptions cardStatus, CardTypeOptions cardType, string accountNumber)
        {
            @Guid = guid;
            Pin = pin;
            ExpiryDate = expirydate;
            CrcCode = crcCode;
            CardNumber = cardNumber;
            CardStatus = cardStatus;
            CardType = cardType;
            AccountNumber = accountNumber;
        }


        [JsonPropertyName("GUID")]
        public Guid @Guid { get; set; }

        [JsonPropertyName("PIN")]
        public string Pin { get; set; }

        public DateOnly ExpiryDate { get; set; }

        [JsonPropertyName("CRC")]
        public string CrcCode { get; set; }

        public string CardNumber { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CardStatusOptions CardStatus { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CardTypeOptions CardType { get; set; }

        public string AccountNumber { get; set; }

        public Account Account { get; set; }


        private void AddToDb()
        {
            Console.WriteLine("hello");
        }

        public override string ToString()
        {
            return $"Card number: {CardNumber}, PIN: {Pin}, Expiry date: {ExpiryDate}, CRC: {CrcCode}, Card status: {CardStatus}, Card type: {CardType}, Account number: {AccountNumber}";
        }
        
        public void PrintAll()
        {
            Console.WriteLine($"Card number: {CardNumber}, PIN: {Pin}, Expiry date: {ExpiryDate}, CRC: {CrcCode}, Card status: {CardStatus}, Card type: {CardType}, Account number: {AccountNumber}, Account: {Account.AccountNumber}");
        }
        
    }





}
