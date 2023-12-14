using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Library
    {

        public void AddBook(string title)
        {
            Books.Add(title);
        }

        public void RemoveBook(string title)
        {
            Books.Remove(title);
        }

        public List<string> Books { get; set; } = new();



        public List<Book> BookObjs { get; set; } = new();

        public void AddBookObj(Book book)
        {
            BookObjs.Add(book);
        }

        public void RemoveBookObj(Book book)
        {
            BookObjs.Remove(book);
        }
    }
}
