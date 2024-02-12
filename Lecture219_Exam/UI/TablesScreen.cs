using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.Models;
using Lecture219_Exam.Utils;

namespace Lecture219_Exam.UI
{
    internal class TablesScreen 
    {
        public static MyTable Print(List<MyTable> tables)
        {
            while (true)
            {
                string text = "Choose a table: \n";
                foreach (var table in tables)
                {
                    text += $"Table {table.Id} - Capacity: {table.Capacity}\n";
                }
                text += "\n> ";
                AppMessage.Display(text);

                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int tableId))
                {
                    MyTable? selectedTable = tables.FirstOrDefault(t => t.Id == tableId);
                    if (selectedTable != null)
                    {
                        return selectedTable;
                    }
                    else
                    {
                        AppMessage.Display("Invalid table. Please try again.", ErrCode.Warning, true);
                    }
                }
                else
                {
                    AppMessage.Display("Invalid input. Please try again.", ErrCode.Warning, true);
                }
            }
            
        }
    }
}
