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
        public IEnumerable<Table> GetAllTables();
        public Table GetTable(int id);
        public void AddTable(Table table);
        public void UpdateTable(Table table);
        public void DeleteTable(int id);

    }
}
