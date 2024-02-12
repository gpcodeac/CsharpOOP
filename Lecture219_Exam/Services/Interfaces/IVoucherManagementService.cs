using Lecture219_Exam.Models;


namespace Lecture219_Exam.Services.Interfaces
{
    internal interface IVoucherManagementService
    {
        int CreateVoucher(int orderId, decimal totalPrice);
        void AddOrderDetails(int orderId, string details);

        string GetVoucherDetails(int voucherId);
    }
}
