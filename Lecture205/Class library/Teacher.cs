using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture205.Class_library
{
    internal class Teacher : Person
    {
        private string subject;
        public string Subject { get => subject; private set { subject = value; } }

        public Teacher(string name, string surname, int yearOfBirth, string subject) : base(name, surname, yearOfBirth)
        {
            Subject = subject;
        }

        protected override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {YearOfBirth} {Subject}");
        }

        public string GetSubject()
        {
            return Subject;
        }
    }
}
