using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Services
{
    internal class TableManagementService : ITableManagementService
    {
        private readonly ITableRepository _tableRepository;

        //public TableManagementService(ITableRepository tableRepository)
        //{
        //    _tableRepository = tableRepository;
        //}

        public TableManagementService()
        {
            _tableRepository = new TableRepository();
        }

        public List<Table> GetAllTables()
        {
            return _tableRepository.GetAllTables().ToList();
        }

        public List<Table> GetAvailableTables()
        {
            return _tableRepository.GetAllTables().Where(t => t.IsAvailable).ToList();
        }

        public void ReserveTable(Table table)
        {
            Table? existingTable = _tableRepository.GetTable(table.Id);
            if (existingTable != null)
            {
                existingTable.IsAvailable = false;
                _tableRepository.UpdateTable(existingTable);
            }
        }

        public void ReleaseTable(Table table)
        {
            Table? existingTable = _tableRepository.GetTable(table.Id);
            if (existingTable != null)
            {
                existingTable.IsAvailable = true;
                _tableRepository.UpdateTable(existingTable);
            }
        }

    }
}
