using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Models
{
    internal interface IMenuItem
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
