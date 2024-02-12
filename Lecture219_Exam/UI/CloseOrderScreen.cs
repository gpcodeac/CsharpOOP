using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Services;
using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.Utils;

namespace Lecture219_Exam.UI
{
    internal class CloseOrderScreen : IScreen
    {

        private readonly IOrderManagementService _orderManagementService = new OrderManagementService();

        public IScreen Print()
        {
            int orderId = _orderManagementService.FindOrder();
            while (true)
            {
                string text = $"""
                Order {orderId} is ready to be closed.
                Are you sure you want to close it? (Y/N)
                
                >
                """;
                AppMessage.Display(text);
                string choice = Console.ReadLine();
                if (choice.ToLower() == "y")
                {
                    _orderManagementService.CloseOrder(orderId);
                    AppMessage.Display($"Order {orderId} has been closed.", ErrCode.Information, true);
                    return new HomeScreen();
                }
                else if (choice.ToLower() == "n")
                {
                    return new HomeScreen();
                }
                else
                {
                    AppMessage.Display("Invalid choice. Please try again.", ErrCode.Warning, true);
                }
            }
        }
    }
}
