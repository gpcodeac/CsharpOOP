using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.Services;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Utils;


namespace Lecture219_Exam.UI
{
    internal class CreateOrderScreen : IScreen
    {
        
        private readonly IOrderManagementService _orderManagementService = new OrderManagementService();

        public IScreen Print()
        {
            int newOrderId = _orderManagementService.CreateOrder();
            while (true)
            {
                string text = $"""
                Order created successfully!
                Order ID: {newOrderId}

                Choose what you want to do:
                1. Add foods
                2. Add drinks
                3. Remove item
                4. Display order

                0. Go back

                """;
                AppMessage.Display(text);
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        _orderManagementService.AddFoodItem(newOrderId);
                        break;
                    case "2":
                        _orderManagementService.AddDrinkItem(newOrderId);
                        break;
                    case "3":
                        _orderManagementService.RemoveItem(newOrderId);
                        break;
                    case "4":
                        _orderManagementService.DisplayOrder(newOrderId);
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
