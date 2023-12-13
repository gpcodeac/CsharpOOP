using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lecture201
{
    //internal class Person
    //{
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //    public Person(string name, string gender) : this(name)
    //    {
    //        Gender = gender;
    //    }
    //    public Person(string name, string gender, DateTime DOB) : this(name, gender) 
    //    {
    //        this.DOB = DOB;
    //    }

    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public DateTime DOB { get; set; }
    //}

    //internal class Person
    //{
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //    public Person(string name, string gender) 
    //    {
    //        Name = name;
    //        Gender = gender;
    //    }
    //    public Person(string name, string gender, DateTime DOB) 
    //    {
    //        Name = name;
    //        Gender = gender;
    //        this.DOB = DOB;
    //    }

    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public DateTime DOB { get; set; }
    //}

    internal class PersonTest
    {
        public PersonTest(string name)
        {
            Name = name;
        }
        public PersonTest(string name, string gender)
        {
            Name = name;
            Gender = gender;
        }
        public PersonTest(string name, string gender, DateTime DOB)
        {
            Name = name;
            Gender = gender;
            this.DOB = DOB;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null) name = value;
                else name = "Unknown name";
            }
        }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}
