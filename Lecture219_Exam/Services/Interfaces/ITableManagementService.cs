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

        public int FindTable();

        public int ReserveTable();

        public void ReleaseTable();

        public void ReleaseTable(int tableId);

    }
}
