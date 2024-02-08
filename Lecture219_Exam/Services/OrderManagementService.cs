using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Repositories;


namespace Lecture219_Exam.Services
{
    internal class OrderManagementService : IOrderManagementService
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IDrinkRepository _drinkRepository;
        private readonly ITableManagementService _tableManagementService;

        //public OrderManagementService(IOrderRepository orderRepository, IFoodRepository foodRepository, IDrinkRepository drinkRepository)
        //{
        //    _orderRepository = orderRepository;
        //    _foodRepository = foodRepository;
        //    _drinkRepository = drinkRepository;
        //}

        public OrderManagementService()
        {
            _orderRepository = new OrderRepository();
            _foodRepository = new FoodRepository();
            _drinkRepository = new DrinkRepository();
            _tableManagementService = new TableManagementService();
        }

        public void CreateOrder()
        {
            //show all tables
            //select table
            //show all items
            //select items
            //add items to order
            //display order
            //save order

            throw new NotImplementedException();
        }

        public void AddItem()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem()
        {
            throw new NotImplementedException();
        }

        public void DisplayOrder()
        {
            throw new NotImplementedException();
        }

        public void DisplayOrders()
        {
            throw new NotImplementedException();
        }

        public void CloseOrder()
        {
            throw new NotImplementedException();
        }

        public void PayOrder()
        {
            throw new NotImplementedException();
        }

        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void ChangeTable()
        {
            throw new NotImplementedException();
        }   
    }
}
