using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture205.Class_library
{
    internal class Student : Person
    {
        private string studentId;
        
        public string StudentId { get => studentId; private set { studentId = value; } }
       
        
        public Student(string name, string surname, int yearOfBirth, string studentId) : base(name, surname, yearOfBirth)
        {
            StudentId = studentId;
        }

        protected override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {YearOfBirth} {StudentId}");
        }

        public string GetStudentId()
        {
            return StudentId;
        }
    }
}
