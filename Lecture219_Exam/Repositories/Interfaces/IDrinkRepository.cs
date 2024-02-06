using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Repositories.Interfaces
{
    internal interface IDrinkRepository
    {
        public IEnumerable<Drink> GetAllDrinks();
        public Drink GetDrink(int id); 
        public void AddDrink(Drink drink);
        public void UpdateDrink(Drink drink);
        public void DeleteDrink(int id);

    }
}
