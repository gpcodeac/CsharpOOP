using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Models;
using Lecture219_Exam.UI;


namespace Lecture219_Exam.Services
{
    internal class TableManagementService : ITableManagementService
    {
        private readonly ITableRepository _tableRepository;

        public TableManagementService()
        {
            _tableRepository = new TableRepository();
        }


        private List<MyTable> GetAllTables()
        {
            return _tableRepository.GetAllTables().ToList();
        }

        private List<MyTable> GetAvailableTables()
        {
            return _tableRepository.GetAllTables().Where(t => t.IsAvailable).ToList();
        }

        private List<MyTable> GetReservedTables()
        {
            return _tableRepository.GetAllTables().Where(t => !t.IsAvailable).ToList();
        }

        public int FindTable()
        {
            List<MyTable> allTables = GetAllTables();
            MyTable selectedTable = TablesScreen.Print(allTables);
            return selectedTable.Id;
        }
       
        public int ReserveTable()
        {
            List<MyTable> availableTables = GetAvailableTables();
            MyTable selectedTable = TablesScreen.Print(availableTables);

            selectedTable.IsAvailable = false;
            _tableRepository.UpdateTable(selectedTable);
            return selectedTable.Id;
        }

        public void ReleaseTable()
        {
            List<MyTable> reservedTables = GetReservedTables();
            MyTable selectedTable = TablesScreen.Print(reservedTables);

            selectedTable.IsAvailable = true;
            _tableRepository.UpdateTable(selectedTable);
        }

        public void ReleaseTable(int tableId)
        {
            MyTable table = _tableRepository.GetTable(tableId);
            table.IsAvailable = true;
            _tableRepository.UpdateTable(table);
        }

    }
}
