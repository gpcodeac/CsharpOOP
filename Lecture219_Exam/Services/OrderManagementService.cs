using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Models;
using Lecture219_Exam.UI;

namespace Lecture219_Exam.Services
{
    internal class OrderManagementService : IOrderManagementService
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IDrinkRepository _drinkRepository;
        private readonly ITableManagementService _tableManagementService;
        private readonly IVoucherManagementService _voucherManagementService;

        public OrderManagementService()
        {
            _orderRepository = new OrderRepository();
            _foodRepository = new FoodRepository();
            _drinkRepository = new DrinkRepository();
            _tableManagementService = new TableManagementService();
            _voucherManagementService = new VoucherManagementService();
        }

        private int GetNextOrderId()
        {
            return _orderRepository.GetAllOrders().Max(o => o.Id) + 1;
        }

        public int CreateOrder()
        {
            Order order = new()
            {
                Id = GetNextOrderId(),
                Date = DateTime.Now,
                TableId = _tableManagementService.ReserveTable(),
            };
            _orderRepository.AddOrder(order);
            return order.Id;
        }

        public void AddFoodItem(int orderId)
        {
            List<Food> foods = _foodRepository.GetAllFoods().ToList();  
            Food selectedFood = FoodsScreen.Print(foods);
            Order order = _orderRepository.GetOrder(orderId);
            order.FoodIds.Add(selectedFood.Id);
            _orderRepository.UpdateOrder(order);
        }

        public void AddDrinkItem(int orderId)
        {
            List<Drink> drinks = _drinkRepository.GetAllDrinks().ToList();
            Drink selectedDrink = DrinksScreen.Print(drinks);
            Order order = _orderRepository.GetOrder(orderId);
            order.DrinkIds.Add(selectedDrink.Id);
            _orderRepository.UpdateOrder(order);
        }

        public void RemoveItem(int orderId)
        {
            List<Drink> orderDrinks = _orderRepository.GetOrder(orderId).DrinkIds.Select(id => _drinkRepository.GetDrink(id)).ToList();
            List<Food> orderFoods = _orderRepository.GetOrder(orderId).FoodIds.Select(id => _foodRepository.GetFood(id)).ToList();
            IMenuItem selectedItemToRemove = RemoveItemScreen.Print(orderFoods, orderDrinks);
            Order order = _orderRepository.GetOrder(orderId);
            if (selectedItemToRemove is Food)
            {
                order.FoodIds.Remove(selectedItemToRemove.Id);
            }
            else
            {
                order.DrinkIds.Remove(selectedItemToRemove.Id);
            }
            _orderRepository.UpdateOrder(order);
        }

        public void DisplayOrder(int orderId)
        {
            //Order order = _orderRepository.GetOrder(orderId);
            //List<Food> orderFoods = order.FoodIds.Select(id => _foodRepository.GetFood(id)).ToList();
            //List<Drink> orderDrinks = order.DrinkIds.Select(id => _drinkRepository.GetDrink(id)).ToList();
            //decimal total = orderFoods.Sum(f => f.Price) + orderDrinks.Sum(d => d.Price);
            //DisplayOrderScreen.Print(order, orderFoods, orderDrinks, total);
            string details = GetOrderDetails(orderId);  
            DisplayOrderScreen.Print(details);
        }

        public int FindOrder()
        {
            int tableId = _tableManagementService.FindTable();
            return _orderRepository.GetAllOrders().FirstOrDefault(o => o.TableId == tableId).Id;   
        }

        public void CloseOrder(int orderId)
        {
            Order order = _orderRepository.GetOrder(orderId);
            decimal totalPrice = order.FoodIds.Select(_foodRepository.GetFood).Sum(f => f.Price) +
                                 order.DrinkIds.Select(_drinkRepository.GetDrink).Sum(d => d.Price);
            int voucher = _voucherManagementService.CreateVoucher(orderId, totalPrice);
            _tableManagementService.ReleaseTable(order.TableId);
        }

        public string GetOrderDetails(int orderId)
        {
            Order order = _orderRepository.GetOrder(orderId);

            string text = $"Order ID: {order.Id}\n" +
                          $"Date: {order.Date}\n" +
                          $"Table ID: {order.TableId}\n" +
                          $"Employee ID: {order.EmployeeId}\n" +
                          "Items:\n\n";

            List<Food> foods = order.FoodIds.Select(id => _foodRepository.GetFood(id)).ToList();
            foreach (var food in foods)
            {
                text = text + $"{food.Name} - {food.Price}\n";
            }
            
            List<Drink> drinks = order.DrinkIds.Select(id => _drinkRepository.GetDrink(id)).ToList();
            foreach (var drink in drinks)
            {
                text = text + $"{drink.Name} - {drink.Price}\n";
            }
            
            decimal total = foods.Sum(f => f.Price) + drinks.Sum(d => d.Price);
            text = text + $"\nTotal: {total}\n";
            return text;
        }

        public void ChangeTable(int orderId)
        {
            throw new NotImplementedException();
        }   
    }
}
