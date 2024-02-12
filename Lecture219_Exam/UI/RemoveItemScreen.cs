using Lecture219_Exam.Models;
using Lecture219_Exam.Utils;

namespace Lecture219_Exam.UI
{
    internal class RemoveItemScreen
    {
        public static IMenuItem Print(List<Food> foods, List<Drink> drinks)
        {
            while (true)
            {
                int tempId = 1;
                string text = "Choose an item to remove: \n";
                foreach (var food in foods)
                {
                    text += $"{tempId}. {food.Name} - {food.Price}\n";
                    tempId++;
                }
                foreach (var drink in drinks)
                {
                    text += $"{tempId}. {drink.Name} - {drink.Price}\n";
                    tempId++;
                }
                text += "\n> ";
                AppMessage.Display(text);

                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int itemId))
                {
                    if (itemId <= foods.Count)
                    {
                        return foods[itemId - 1];
                    }
                    else if (itemId <= foods.Count + drinks.Count)
                    {
                        return drinks[itemId - foods.Count - 1];
                    }
                    else
                    {
                        AppMessage.Display("Invalid item. Please try again.", ErrCode.Warning, true);
                    }
                }
                else
                {
                    AppMessage.Display("Invalid input. Please try again.", ErrCode.Warning, true);
                }
            }
        }
    }
}
