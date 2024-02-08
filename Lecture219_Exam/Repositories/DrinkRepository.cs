using Lecture219_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Lecture219_Exam.Repositories.Interfaces;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Lecture219_Exam.Repositories
{
    internal class DrinkRepository : IDrinkRepository
    {
        
        private readonly List<Drink> _drinks = new();

        public DrinkRepository()
        {
            var jsondrinks = File.ReadAllText(@"../../../Data/Drinks.json");
            _drinks = JsonSerializer.Deserialize<List<Drink>>(jsondrinks);
        }

        public IEnumerable<Drink> GetAllDrinks()
        {
            return _drinks;
        }

        public Drink GetDrink(int id)
        {
            return _drinks.FirstOrDefault(d => d.Id == id);
        }

        public void AddDrink(Drink drink)
        {
            _drinks.Add(drink);
            Save();
        }

        public void UpdateDrink(Drink drink)
        {
            var existingDrink = _drinks.FirstOrDefault(d => d.Id == drink.Id); //should I replace an object or update its properties?
            if (existingDrink != null)
            {
                existingDrink.Name = drink.Name;
                existingDrink.Price = drink.Price;
            }
            Save();
        }

        public void DeleteDrink(int id)
        {
            var drink = _drinks.FirstOrDefault(d => d.Id == id);
            if (drink != null)
            {
                _drinks.Remove(drink);
            }
            Save();
        }

        private void Save()
        {
            var jsondrinks = JsonSerializer.Serialize(_drinks);
            File.WriteAllText(@"../../../Data/Drinks.json", jsondrinks);
        }

    }
}
