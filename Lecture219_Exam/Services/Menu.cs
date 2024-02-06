using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Services
{
    internal class Menu
    {
        private Dictionary<string, decimal> _items = new Dictionary<string, decimal>();

        public Menu()
        {
            string path = @"../../../Data/Foods.txt";
            string[] foods = File.ReadAllLines(path);
            foreach (string food in foods)
            {
                string[] parts = food.Split(',');
                string name = parts[0];
                decimal price = decimal.Parse(parts[1]);
                _items.Add(name, price);
            }

            path = @"../../../Data/Drinks.txt";
            string[] drinks = File.ReadAllLines(path);
            foreach (string drink in drinks)
            {
                string[] parts = drink.Split(',');
                string name = parts[0];
                decimal price = decimal.Parse(parts[1]);
                _items.Add(name, price);
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("====");
            foreach (KeyValuePair<string, decimal> item in _items)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
