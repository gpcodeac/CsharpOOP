using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Unused
{
    internal class GPT
    {
    }



    public class Screen
    {
        public string Name { get; }
        public List<Screen> Children { get; }

        public Screen(string name)
        {
            Name = name;
            Children = new List<Screen>();
        }

        public void AddChild(Screen child)
        {
            Children.Add(child);
        }

        public void Render()
        {
            Console.WriteLine($"Rendering {Name} Screen...");
        }
    }

    public class NavigationTree
    {
        private Screen root;
        private Screen currentScreen;

        public NavigationTree(Screen root)
        {
            this.root = root;
            currentScreen = root;
        }

        public Screen GetCurrentScreen()
        {
            return currentScreen;
        }

        public void NavigateTo(Screen screen)
        {
            currentScreen = screen;
        }

        public void AddChild(Screen parent, Screen child)
        {
            parent.AddChild(child);
        }
    }

    class Programs
    {
        static void Mains()
        {
            // Create the root screen
            Screen mainScreen = new Screen("Main");

            // Create the navigation tree
            NavigationTree navigationTree = new NavigationTree(mainScreen);

            // Example: Add screens dynamically during runtime
            Screen settingsScreen = new Screen("Settings");
            Screen aboutScreen = new Screen("About");
            Screen helpScreen = new Screen("Help");

            // Add screens dynamically to the navigation tree
            navigationTree.AddChild(mainScreen, settingsScreen);
            navigationTree.AddChild(mainScreen, aboutScreen);
            navigationTree.AddChild(mainScreen, helpScreen);

            // Example application loop
            while (true)
            {
                Console.Clear();
                Screen currentScreen = navigationTree.GetCurrentScreen();
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
                        navigationTree.NavigateTo(settingsScreen);
                        break;
                    case "2":
                        navigationTree.NavigateTo(aboutScreen);
                        break;
                    case "3":
                        navigationTree.NavigateTo(helpScreen);
                        break;
                    case "0":
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
