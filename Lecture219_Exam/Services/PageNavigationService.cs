using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.UI;
using Lecture219_Exam.Unused;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.ZUnused;

namespace Lecture219_Exam.Services
{
    internal class PageNavigationService 
    {
     
        private IScreen _currentScreen;

        public PageNavigationService()
        {
            _currentScreen = new LoginScreen();
        }

        public PageNavigationService(string screenName)
        {
            //_currentScreen = ScreenFactory.CreateScreen(screenName);
        }

        public void Run()
        {
            while (true)
            {
                _currentScreen = _currentScreen.Print();
            }
        }

        //public void GoBack()
        //{
        //    _currentScreen = _previousScreen;
        //}

        //public IScreen GetCurrentScreen()
        //{
        //    return _currentScreen;
        //}

        //public void NavigateTo(IScreen screen)
        //{
        //    _previousScreen = _currentScreen;
        //    _currentScreen = screen;
        //}


    }
}


