using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Lecture219_Exam.ViewModels;

namespace Lecture219_Exam.Models
{
    internal class Order
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public int TableId { get; set; }
        
        public int EmployeeId { get; set; }
        
        public List<int> FoodIds { get; set; }
        
        public List<int> DrinkIds { get; set; }

        //public Employee Employee { get; set; } = new Employee();

        //public List<Food> FoodItems { get; set; } = new List<Food>();

        //public List<Drink> DrinkItems { get; set; } = new List<Drink>();

        //public Table Table { get; set; } = new Table();

        //public List<IMenuItem> Items { get; set; } = new List<IMenuItem>(); 
    }
}
