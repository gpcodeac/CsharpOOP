using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.UI;
using Lecture219_Exam.Unused;

namespace Lecture219_Exam.Services
{
    internal class PageNavigationService
    {
        private readonly Dictionary<Screen, List<Screen>> edges;

        public PageNavigationService()
        {
            edges = new Dictionary<Screen, List<Screen>>();
        }

        public void AddScreen(Screen screen)
        {
            if (!edges.ContainsKey(screen))
            {
                edges[screen] = new List<Screen>();
            }
        }

        public void AddPath(Screen fromScreen, Screen toScreen)
        {
            AddScreen(fromScreen);
            AddScreen(toScreen);

            edges[fromScreen].Add(toScreen);
        }

        public List<Screen> GetPossiblePaths(Screen fromScreen)
        {
            return edges.ContainsKey(fromScreen) ? edges[fromScreen] : new List<Screen>();
        }
    }
}


