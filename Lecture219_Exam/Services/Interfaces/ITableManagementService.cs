using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Services.Interfaces
{
    internal interface ITableManagementService
    {
        public List<Table> GetAllTables();

        public List<Table> GetAvailableTables();

        //public Table GetTable(int id);

        public void ReserveTable(Table table);

        public void ReleaseTable(Table table);

    }
}
