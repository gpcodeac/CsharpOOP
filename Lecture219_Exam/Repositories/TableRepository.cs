using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class TableRepository : ITableRepository
    {
        private readonly List<MyTable> _tables = new();

        public TableRepository()
        {
            var jsontables = File.ReadAllText(@"../../../Data/Tables.json");
            _tables = JsonSerializer.Deserialize<List<MyTable>>(jsontables);
        }

        public IEnumerable<MyTable> GetAllTables()
        {
            return _tables;
        }

        public MyTable GetTable(int id)
        {
            return _tables.FirstOrDefault(t => t.Id == id);
        }

        public void AddTable(MyTable table)
        {
            _tables.Add(table);
            Save();
        }

        public void UpdateTable(MyTable table)
        {
            MyTable? existingTable = _tables.FirstOrDefault(t => t.Id == table.Id); //should I replace an object or update its properties?
            if (existingTable != null)
            {
                existingTable.Capacity = table.Capacity;
                existingTable.IsAvailable = table.IsAvailable;
            }
            Save();
        }

        public void DeleteTable(int id)
        {
            MyTable? table = _tables.FirstOrDefault(t => t.Id == id);
            if (table != null)
            {
                _tables.Remove(table);
            }
            Save();
        }

        private void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(_tables, options);
            File.WriteAllText(@"../../../Data/Tables.json", json);
        }
    }
}
