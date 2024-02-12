using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Repositories.Interfaces
{
    internal interface ITableRepository
    {
        public IEnumerable<MyTable> GetAllTables();
        public MyTable GetTable(int id);
        public void AddTable(MyTable table);
        public void UpdateTable(MyTable table);
        public void DeleteTable(int id);

    }
}
