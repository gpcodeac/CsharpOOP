using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Unused
{
    internal class MenuItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public MenuItemType Type { get; set; }
    }

    enum MenuItemType
    {
        Food,
        Drink
    }
}
