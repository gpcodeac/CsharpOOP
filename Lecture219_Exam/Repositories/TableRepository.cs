using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class TableRepository: ITableRepository
    {
        private readonly List<Table> _tables = new();

        public IEnumerable<Table> GetAllTables()
        {
            return _tables;
        }

        public Table GetTable(int id)
        {
            return _tables.FirstOrDefault(t => t.Id == id);
        }

        public void AddTable(Table table)
        {
            _tables.Add(table);
        }

        public void UpdateTable(Table table)
        {
            Table? existingTable = _tables.FirstOrDefault(t => t.Id == table.Id); //should I replace an object or update its properties?
            if (existingTable != null)
            {
                existingTable.Seats = table.Seats;
                existingTable.IsAvailable = table.IsAvailable;
            }
        }

        public void DeleteTable(int id)
        {
            Table? table = _tables.FirstOrDefault(t => t.Id == id);
            if (table != null)
            {
                _tables.Remove(table);
            }
        }
    }
}
