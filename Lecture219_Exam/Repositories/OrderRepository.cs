using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class OrderRepository : IOrderRepository
    {

        private readonly List<Order> _orders = new();

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders;
        }

        public Order GetOrder(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            int ix = _orders.FindIndex(o => o.Id == order.Id);
            if (ix != -1)
            {
                _orders[ix] = order;
            }
        }

        public void DeleteOrder(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id); //where is the uniqueness constraint being handled? in code, or purely in db level?
            if (order != null)
            {
                _orders.Remove(order);
            }
        }
    }
}
