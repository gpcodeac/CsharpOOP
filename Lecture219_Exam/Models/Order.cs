using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.ViewModels;

namespace Lecture219_Exam.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }  = new Employee();
        public List<IMenuItem> Items { get; set; }
        public Table Table { get; set; } = new Table();
    }
}
