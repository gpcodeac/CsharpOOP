using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Repositories.Interfaces
{
    internal interface IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders();
        public Order GetOrder(int id);
        public void AddOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(int id);
    }
}
