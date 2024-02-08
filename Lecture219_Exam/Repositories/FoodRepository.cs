using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class FoodRepository : IFoodRepository
    {
        
        private readonly List<Food> _foods = new();

        public FoodRepository()
        {
            var jsonfoods = File.ReadAllText(@"../../../Data/Foods.json");
            _foods = JsonSerializer.Deserialize<List<Food>>(jsonfoods);
        }

        public IEnumerable<Food> GetAllFoods()
        {
            return _foods;
        }

        public Food GetFood(int id)
        {
            return _foods.FirstOrDefault(f => f.Id == id);
        }

        public void AddFood(Food food)
        {
            _foods.Add(food);
            Save();
        }

        public void UpdateFood(Food food)
        {
            Food? existingFood = _foods.FirstOrDefault(f => f.Id == food.Id); //should I replace an object or update its properties?
            if (existingFood != null)
            {
                existingFood.Name = food.Name;
                existingFood.Price = food.Price;
            }
            Save();
        }

        public void DeleteFood(int id)
        {
            Food? food = _foods.FirstOrDefault(f => f.Id == id);
            if (food != null)
            {
                _foods.Remove(food);
            }
            Save(); 
        }

        private void Save()
        {
            var jsonfoods = JsonSerializer.Serialize(_foods);
            File.WriteAllText(@"../../../Data/Foods.json", jsonfoods);
        }
    }
}
