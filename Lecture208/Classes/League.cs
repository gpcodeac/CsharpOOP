using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class League<T> where T: Sport
    {

        private string _name;
        private int _yearOfEstablishment;
        //private int _numberOfTeams;
        private List<Team<T>> _teams;

        public string Name { get; set; }
        public int YearOfEstablishment { 
            get { return _yearOfEstablishment; }
            set { _yearOfEstablishment = value; } }
        public int NumberOfTeams { get { return _teams.Count; } }
        public List<Team<T>> Teams { get; set; } = new List<Team<T>>();

        public League()
        {
        }

        public League(string name, int yearOfEstablishment)
        {
            Name = name;
            YearOfEstablishment = yearOfEstablishment;
        }

        public void AddTeam(Team<T> team)
        {
            Teams.Add(team);
        }

        public void RemoveTeam(Team<T> team)
        {
            Teams.Remove(team);
        }

        public void ShowTeams()
        {
            foreach (var team in Teams)
            {
                Console.WriteLine($"Name: {team.Name}, Year of Establishment: {team.YearOfEstablishment}, Number of Members: {team.NumberOfMembers}");
            }
        }
        //public void ShowLeague()
        //{
        //    Console.WriteLine($"Name: {Name}, Year of Establishment: {YearOfEstablishment}, Number of Teams: {NumberOfTeams}");
        //}
    }
}
