using Lecture219_Exam.Unused;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.ZUnused
{
    internal static class NavigationTree
    {

        public static Dictionary<string, List<string>> tree = new Dictionary<string, List<string>>()
        {
            { "Home", new List<string> { "Create Order", "Change Order", "Close Order" } },
            { "CreateOrder", new List<string> { "Home" } },
            { "ChangeOrder", new List<string> { "Home" } },
            { "CloseOrder", new List<string> { "Home" } }
        };



        //private Screen root;
        //private Screen currentScreen;

        //public NavigationTree(Screen root)
        //{
        //    this.root = root;
        //    currentScreen = root;
        //}

        //public Screen GetCurrentScreen()
        //{
        //    return currentScreen;
        //}

        //public void NavigateTo(Screen screen)
        //{
        //    currentScreen = screen;
        //}

        //public void AddChild(Screen parent, Screen child)
        //{
        //    parent.AddChild(child);
        //}






        //private Dictionary<string, Type> screenTypes; // maybe use <string<List<string>> to combine with child-parent relationship
        //private IScreen currentScreen;

        //public NavigationTree()
        //{
        //    screenTypes = new Dictionary<string, Type>
        //    {
        //        { "Main", typeof(MainScreen) },
        //        { "Settings", typeof(SettingsScreen) },
        //        { "About", typeof(AboutScreen) },
        //        { "Help", typeof(HelpScreen) }
        //    };

        //    currentScreen = CreateScreen("Main");
        //}

        //public IScreen GetCurrentScreen()
        //{
        //    return currentScreen;
        //}

        //public void NavigateTo(string screenName)
        //{
        //    currentScreen.Dispose();
        //    currentScreen = CreateScreen(screenName);
        //}

        //private IScreen CreateScreen(string screenName)
        //{
        //    if (screenTypes.TryGetValue(screenName, out Type screenType))
        //    {
        //        return (IScreen)Activator.CreateInstance(screenType);
        //    }

        //    throw new ArgumentException("Invalid screen name");
        //}


    }
}
