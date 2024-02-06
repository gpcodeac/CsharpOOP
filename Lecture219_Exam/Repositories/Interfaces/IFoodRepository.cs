using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Repositories.Interfaces
{
    internal interface IFoodRepository
    {
        public IEnumerable<Food> GetAllFoods();
        public Food GetFood(int id);
        public void AddFood(Food food);
        public void UpdateFood(Food food);
        public void DeleteFood(int id);
    }
}
