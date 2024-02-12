using System;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Services;
using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.Utils;

namespace Lecture219_Exam.UI
{
    internal class ChangeOrderScreen : IScreen
    {

        private readonly IOrderManagementService _orderManagementService = new OrderManagementService();

        public IScreen Print()
        {
            int orderId = _orderManagementService.FindOrder();
            while (true)
            {
                string text = $"""
                Change Order Screen
                Order ID: {orderId}

                Choose what you want to do:
                1. Add foods
                2. Add drinks
                3. Remove item
                4. Display order
                5. Move to another table

                0. Go back

                >
                """;
                AppMessage.Display(text);
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        _orderManagementService.AddFoodItem(orderId);
                        break;
                    case "2":
                        _orderManagementService.AddDrinkItem(orderId);
                        break;
                    case "3":
                        _orderManagementService.RemoveItem(orderId);
                        break;
                    case "4":
                        _orderManagementService.DisplayOrder(orderId);
                        break;
                    case "5":
                        _orderManagementService.ChangeTable(orderId);
                        break;
                    case "0":
                        return new HomeScreen();
                    default:
                        AppMessage.Display("Invalid choice. Please try again.", ErrCode.Warning, true);
                        break;
                }
            }
        }
    }
}
