using Lecture219_Exam.Models;
using Lecture219_Exam.Utils;


namespace Lecture219_Exam.UI
{
    internal class FoodsScreen
    {
        public static Food Print(List<Food> foods)
        {
            while (true)
            {
                string text = "Choose a food: \n";
                foreach (var food in foods)
                {
                    text += $"{food.Id} - {food.Name} - {food.Price}\n";
                }
                text += "\n> ";
                AppMessage.Display(text);

                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int foodId))
                {
                    Food? selectedFood = foods.FirstOrDefault(f => f.Id == foodId);
                    if (selectedFood != null)
                    {
                        return selectedFood;
                    }
                    else
                    {
                        AppMessage.Display("Invalid food. Please try again.", ErrCode.Warning, true);
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
