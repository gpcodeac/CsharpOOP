using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Book
    {
        public Book() { }

        public Book(int id, string title, string author, int year, int pages)
        {
            Id = id; 
            Title = title; 
            Author = author; 
            Year = year;
            Pages = pages;
        }

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Author { get; set; } = string.Empty;
        public int Pages { get; set; }

        public double ReadTime()
        {
            return Pages / (double)50;
        }

    }
}
