using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Models;


namespace Lecture219_Exam.Services
{
    internal class VoucherManagementService : IVoucherManagementService
    {

        private readonly IVoucherRepository _voucherRepository;

        public VoucherManagementService()
        {
            _voucherRepository = new VoucherRepository();
        }

        private int GetNextVoucherId()
        {
            return _voucherRepository.GetAllVouchers().Max(o => o.Id) + 1;
        }

        public int CreateVoucher(int orderId, decimal totalPrice)
        {
            Voucher voucher = new()
            {
                Id = GetNextVoucherId(),
                OrderId = orderId,
                TotalPrice = totalPrice,
                Discount = 0,
                FinalPrice = totalPrice,
                OrderDetails = ""
            };
            _voucherRepository.AddVoucher(voucher);
            return voucher.Id;
        }

        public void AddOrderDetails(int orderId, string details)
        {
            Voucher voucher = _voucherRepository.GetAllVouchers().FirstOrDefault(v => v.OrderId == orderId);
            voucher.OrderDetails = details;
            _voucherRepository.UpdateVoucher(voucher);
        }

        public string GetVoucherDetails(int voucherId)
        {
            return _voucherRepository.GetVoucher(voucherId).OrderDetails;
        } 

    }
}
