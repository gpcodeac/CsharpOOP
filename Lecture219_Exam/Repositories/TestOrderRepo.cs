using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class TestOrderRepo : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public IEnumerable<Order> GetAllOrders()
        {
            Console.WriteLine("shits on fire YO.");
            IEnumerable<Order> testbullshit = new List<Order>();
            return testbullshit;
        }

        public Order GetOrder(int id)
        {
            Console.WriteLine("this is some other shit");
            Order? order = null;
            return order;
        }

        public void AddOrder(Order order)
        {
            Console.WriteLine("pretenting to add something but actully i dont care"); ;
        }

        public void UpdateOrder(Order order)
        {
            Console.WriteLine("ok done, almost");
        }

        public void DeleteOrder(int id)
        {
            Console.WriteLine("gg get wiped");
            _orders.Clear();
        }
    }
}
