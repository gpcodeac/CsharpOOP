using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lecture219_Exam.Models
{
    internal class Order
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public int TableId { get; set; }
        
        public int EmployeeId { get; set; }
        
        public List<int> FoodIds { get; set; } = new List<int>();
        
        public List<int> DrinkIds { get; set; } = new List<int>();
    }
}
