using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Services;

namespace Lecture219_Exam
{
    internal class POSSystem
    {

        private IEmployeeRepository _employeeRepository;
        private IVoucherRepository _voucherRepository;
        private ITableRepository _tableRepository;
        private IOrderRepository _orderRepository;
        private IFoodRepository _foodRepository;
        private IDrinkRepository _drinkRepository;


        public POSSystem()
        {
            _employeeRepository = new EmployeeRepository();
            _voucherRepository = new VoucherRepository();
            _tableRepository = new TableRepository();
            _orderRepository = new OrderRepository();
            _foodRepository = new FoodRepository();
            _drinkRepository = new DrinkRepository();

            Init();
        }

        private void Init()
        {
            var employees = File.ReadAllLines(@"../../../Data/Employees.txt");
            foreach (string employee in employees)
            {
                string[] parts = employee.Split(',');
                int id = int.Parse(parts[0]);
                string password = parts[1];
                string name = parts[2];
                _employeeRepository.AddEmployee(new Employee() { Id = id, Name = name, Password = password });
            }

            var vouchers = File.ReadAllLines(@"../../../Data/Vouchers.txt");
            foreach (string voucher in vouchers)
            {
                string[] parts = voucher.Split(',');
                int id = int.Parse(parts[0]);
                int orderId = int.Parse(parts[1]);
                decimal totalPrice = decimal.Parse(parts[2]);
                decimal discount = decimal.Parse(parts[3]);
                decimal finalPrice = decimal.Parse(parts[4]);
                _voucherRepository.AddVoucher(new Voucher() { Id = id, OrderId = orderId, TotalPrice = totalPrice, Discount = discount, FinalPrice = discount });
            }

            var tables = File.ReadAllLines(@"../../../Data/Tables.txt");
            foreach (string table in tables)
            {
                string[] parts = table.Split(',');
                int id = int.Parse(parts[0]);
                int capacity = int.Parse(parts[1]);
                bool isAvailable = bool.Parse(parts[2]);
                _tableRepository.AddTable(new Table() { Id = id, Capacity = capacity, IsAvailable = isAvailable });
            }

            var orders = File.ReadAllLines(@"../../../Data/Orders.txt");
            foreach (string order in orders)
            {
                string[] parts = order.Split(',');
                int id = int.Parse(parts[0]);
                DateTime date = DateTime.Parse(parts[1]);
                //_orderRepository.AddOrder(new Order() { Id = id, Date = date, Employee = _employeeRepository.GetEmployee(employeeId), Table = _tableRepository.GetTable(tableId) });
            }

            var foods = File.ReadAllLines(@"../../../Data/Foods.txt");
            foreach (string food in foods)
            {
                string[] parts = food.Split(',');
                int id = int.Parse(parts[0]);
                string name = parts[1];
                decimal price = decimal.Parse(parts[2]);
                _foodRepository.AddFood(new Food() { Id = id, Name = name, Price = price });
            }

            var drinks = File.ReadAllLines(@"../../../Data/Drinks.txt");
            foreach (string drink in drinks)
            {
                string[] parts = drink.Split(',');
                int id = int.Parse(parts[0]);
                string name = parts[1];
                decimal price = decimal.Parse(parts[2]);
                _drinkRepository.AddDrink(new Drink() { Id = id, Name = name, Price = price });
            }
        }


        public void Run()
        {

        }


    }
}
