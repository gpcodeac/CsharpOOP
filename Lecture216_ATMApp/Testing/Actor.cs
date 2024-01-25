using System.Text.Json.Serialization;

namespace Lecture216_ATMApp.Testing
{
    internal class Actor
    {

        public Actor(string name, int age, string bornAt)
        {
            Name = name;
            Age = age;
            BornAt = bornAt;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string BornAt { get; set; }

        [JsonPropertyName("binding type")] //mapping json key, if it has spaces
        public string BindingType { get; set; }


    }
}
