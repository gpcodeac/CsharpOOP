using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Book
    {

        public Book(string title, string author, int year) 
        { 
            Title = title;
            Author = author;
            Year = year;
        }
        public Book(string title, string author, int year, string countryOfPublishing)
        {
            Title = title;
            Author = author;
            Year = year;
            CountryOfPublishing = countryOfPublishing;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string CountryOfPublishing { get; set; }
    }
}
