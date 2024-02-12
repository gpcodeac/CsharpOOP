using System;
using Lecture219_Exam.Models;
using Lecture219_Exam.Utils;

namespace Lecture219_Exam.UI
{
    internal class DisplayOrderScreen
    {
        //public static void Print(Order order, List<Food> foods, List<Drink> drinks, decimal total)
        //{
        //    string text = $"Order ID: {order.Id}\n" +
        //                  $"Date: {order.Date}\n" +
        //                  $"Table ID: {order.TableId}\n" +
        //                  $"Employee ID: {order.EmployeeId}\n" +
        //                  "Items:\n\n";
        //    foreach (var food in foods)
        //    {
        //        text = text + $"{food.Name} - {food.Price}\n";
        //    }
        //    foreach (var drink in drinks)
        //    {
        //        text = text + $"{drink.Name} - {drink.Price}\n";
        //    }
        //    text = text + $"\nTotal: {total}\n";

        //    AppMessage.Display(text, hold: true);
        //}

        public static void Print(string details)
        {
            AppMessage.Display(details, hold: true);
        }
    }
}
