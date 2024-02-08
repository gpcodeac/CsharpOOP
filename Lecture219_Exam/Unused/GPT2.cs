using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Unused
{
    internal class GPT2
    {
    }



    public interface IScreen
    {
        void Render();
        void Dispose();
    }

    public class MainScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering Main Screen...");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Main Screen...");
        }
    }

    public class SettingsScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering Settings Screen...");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Settings Screen...");
        }
    }

    public class AboutScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering About Screen...");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing About Screen...");
        }
    }

    public class HelpScreen : IScreen
    {
        public void Render()
        {
            Console.WriteLine("Rendering Help Screen...");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Help Screen...");
        }
    }

    public class NavigationTree
    {
        private Dictionary<string, Type> screenTypes; // maybe use <string<List<string>> to combine with child-parent relationship
        private IScreen currentScreen;

        public NavigationTree()
        {
            screenTypes = new Dictionary<string, Type>
            {
                { "Main", typeof(MainScreen) },
                { "Settings", typeof(SettingsScreen) },
                { "About", typeof(AboutScreen) },
                { "Help", typeof(HelpScreen) }
            };

            currentScreen = CreateScreen("Main");
        }

        public IScreen GetCurrentScreen()
        {
            return currentScreen;
        }

        public void NavigateTo(string screenName)
        {
            currentScreen.Dispose();
            currentScreen = CreateScreen(screenName);
        }

        private IScreen CreateScreen(string screenName)
        {
            if (screenTypes.TryGetValue(screenName, out Type screenType))
            {
                return (IScreen)Activator.CreateInstance(screenType);
            }

            throw new ArgumentException("Invalid screen name");
        }
    }

    class Programss
    {
        static void Mainss()
        {
            NavigationTree navigationTree = new NavigationTree();

            // Example application loop
            while (true)
            {
                Console.Clear();
                IScreen currentScreen = navigationTree.GetCurrentScreen();
                currentScreen.Render();

                // Get user input for navigation
                Console.WriteLine("1. Go to Settings");
                Console.WriteLine("2. Go to About");
                Console.WriteLine("3. Go to Help");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        navigationTree.NavigateTo("Settings");
                        break;
                    case "2":
                        navigationTree.NavigateTo("About");
                        break;
                    case "3":
                        navigationTree.NavigateTo("Help");
                        break;
                    case "0":
                        currentScreen.Dispose();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }


}
