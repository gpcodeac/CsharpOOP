using Lecture219_Exam.Utils;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.UI
{
    internal class DrinksScreen
    {
        public static Drink Print(List<Drink> drinks)
        {
            while (true)
            {
                string text = "Choose a drink: \n";
                foreach (var drink in drinks)
                {
                    text += $"{drink.Id} - {drink.Name} - {drink.Price}\n";
                }
                text += "\n> ";
                AppMessage.Display(text);

                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int drinkId))
                {
                    Drink? selectedDrink = drinks.FirstOrDefault(d => d.Id == drinkId);
                    if (selectedDrink != null)
                    {
                        return selectedDrink;
                    }
                    else
                    {
                        AppMessage.Display("Invalid drink. Please try again.", ErrCode.Warning, true);
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
