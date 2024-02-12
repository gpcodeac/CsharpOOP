using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Services.Interfaces
{
    internal interface IOrderManagementService
    {
        int FindOrder();
        int CreateOrder();
        void AddFoodItem(int orderId);
        void AddDrinkItem(int orderId);
        void RemoveItem(int orderId);
        void DisplayOrder(int orderId);
        void ChangeTable(int orderId);
        void CloseOrder(int orderId);
    }
}
