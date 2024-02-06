using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Services;

namespace Lecture219_Exam
{
    internal class POSSystem
    {

        private IEmployeeRepository _employeeRepository;
        private IVoucherRepository _voucherRepository;
        private IOrderRepository _orderRepository;
        private ITableRepository _tableRepository;
        private IFoodRepository _foodRepository;
        private IDrinkRepository _drinkRepository;


        public POSSystem()
        {
            _menu = new Menu();
            _employees = File.ReadAllLines(@"../../../Data/Employees.txt").Select(x => new Employee(x.Split(','))).ToList();
            _vouchers = new List<Voucher>();
            _orders = new List<Order>();
        }

        public void Run()
        {

        }


    }
}
