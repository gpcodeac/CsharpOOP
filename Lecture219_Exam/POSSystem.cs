using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Services;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.UI;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Lecture219_Exam.Unused;

namespace Lecture219_Exam
{
    internal class POSSystem
    {

        private IVoucherRepository _voucherRepository;
        private ITableRepository _tableRepository;
        private IFoodRepository _foodRepository;
        private IDrinkRepository _drinkRepository;
        private IEmployeeRepository _employeeRepository;
        private IOrderRepository _orderRepository;
        
        private IPageNavigationService _pageNavigationService;
        private IOrderManagementService _orderManagementService;
        private IUserLoginService _userLoginService;
        private IVoucherManagementService _voucherManagementService;
        private ITableManagementService _tableManagementService;


        public POSSystem()
        {
            //_employeeRepository = new EmployeeRepository();
            //_voucherRepository = new VoucherRepository();
            //_tableRepository = new TableRepository();
            //_orderRepository = new OrderRepository();
            //_foodRepository = new FoodRepository();
            //_drinkRepository = new DrinkRepository();


            _pageNavigationService = new PageNavigationService();
            _userLoginService = new UserLoginService(_employeeRepository);
            _tableManagementService = new TableManagementService();
            _orderManagementService = new OrderManagementService(_orderRepository, _foodRepository, _drinkRepository);
            _voucherManagementService = new VoucherManagementService(_voucherRepository, _orderRepository);

            InitData();     //maybe do not populate repos with data, move that into GetAll() methods
            InitNavigation();
        }

        private void InitData()
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
                _voucherRepository.AddVoucher(new Voucher() { Id = id, OrderId = orderId, TotalPrice = totalPrice, Discount = discount, FinalPrice = finalPrice });
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
                //int tableId = int.Parse(parts[2]);
                //int employeeId = int.Parse(parts[3]);
                //int foodId = int.Parse(parts[4]);
                //int drinkId = int.Parse(parts[5]);
                ////_orderRepository.AddOrder(new Order() { Id = id, Date = date, Employee = _employeeRepository.GetEmployee(employeeId), Table = _tableRepository.GetTable(tableId) });
                //_orders.Add(new Order() { Id = id, TableId = tableId, Date = date });
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

        private void InitNavigation()
        {
            Screen loginScreen = new Screen("Login");
            Screen mainScreen = new Screen("Main");
            
            Screen createOrderScreen = new Screen("Create Order"); 
            Screen chooseTableScreen = new Screen("Choose Table");
            Screen chooseFoodScreen = new Screen("Choose Food");
            Screen chooseDrinkScreen = new Screen("Choose Drink");
            Screen orderSummaryScreen = new Screen("Order Summary");

            Screen changeOrderScreen = new Screen("Change Order");
            Screen removeItemScreen = new Screen("Remove Item");
            Screen closeOrderScreen = new Screen("Close Order");
            Screen emailVoucherScreen = new Screen("Email Voucher");


            PageNavigationService graph = new PageNavigationService();
            graph.AddPath(loginScreen, mainScreen);

            graph.AddPath(mainScreen, createOrderScreen);
            graph.AddPath(mainScreen, changeOrderScreen);
            graph.AddPath(mainScreen, closeOrderScreen);
            graph.AddPath(mainScreen, loginScreen);

            graph.AddPath(createOrderScreen, chooseTableScreen);
            graph.AddPath(chooseTableScreen, createOrderScreen);
            graph.AddPath(createOrderScreen, chooseFoodScreen);
            graph.AddPath(chooseFoodScreen, createOrderScreen);
            graph.AddPath(createOrderScreen, chooseDrinkScreen);
            graph.AddPath(chooseDrinkScreen, createOrderScreen);
            graph.AddPath(createOrderScreen, orderSummaryScreen);
            graph.AddPath(orderSummaryScreen, mainScreen);
            graph.AddPath(createOrderScreen, mainScreen);

            graph.AddPath(mainScreen, changeOrderScreen);
            graph.AddPath(changeOrderScreen, chooseFoodScreen);
            graph.AddPath(chooseFoodScreen, changeOrderScreen);
            graph.AddPath(changeOrderScreen, chooseDrinkScreen);
            graph.AddPath(chooseDrinkScreen, changeOrderScreen);
            graph.AddPath(changeOrderScreen, removeItemScreen);
            graph.AddPath(removeItemScreen, changeOrderScreen);
            graph.AddPath(changeOrderScreen, mainScreen);

            graph.AddPath(mainScreen, closeOrderScreen);
            graph.AddPath(closeOrderScreen, emailVoucherScreen);
            graph.AddPath(emailVoucherScreen, mainScreen);
            graph.AddPath(closeOrderScreen, mainScreen);
        }

        public void Run()
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Print();


        }


    }
}
