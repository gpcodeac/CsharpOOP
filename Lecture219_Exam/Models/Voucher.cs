using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Models
{
    internal class Voucher
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }
        
        //public int TableId { get; set; }
        //public DateTime Date { get; set; }
        //public int EmployeeId { get; set; }
    }
}
