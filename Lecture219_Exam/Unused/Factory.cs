using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Unused
{
    internal class Factory
    {
    }


    public interface IScreen
    {
        void Render();
    }

    public class MainScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering Main Screen...");
        }
    }

    public class SettingsScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering Settings Screen...");
        }
    }

    public class AboutScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering About Screen...");
        }
    }

    public class HelpScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering Help Screen...");
        }
    }

    public class ScreenFactory
    {
        public static IScreen CreateScreen(string screenName)
        {
            switch (screenName.ToLower())
            {
                case "main":
                    return new MainScreen();
                case "settings":
                    return new SettingsScreen();
                case "about":
                    return new AboutScreen();
                case "help":
                    return new HelpScreen();
                default:
                    throw new ArgumentException("Invalid screen name");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Example usage of the ScreenFactory
            IScreen mainScreen = ScreenFactory.CreateScreen("Main");
            IScreen settingsScreen = ScreenFactory.CreateScreen("Settings");

            mainScreen.Render();
            settingsScreen.Render();
        }
    }



}
