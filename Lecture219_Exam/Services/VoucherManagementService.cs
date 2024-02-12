using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Models;


namespace Lecture219_Exam.Services
{
    internal class VoucherManagementService : IVoucherManagementService
    {

        private readonly IVoucherRepository _voucherRepository;
        private readonly IOrderManagementService _orderManagementService = null;

        public VoucherManagementService()
        {
            _voucherRepository = new VoucherRepository();
        }

        public VoucherManagementService(IOrderManagementService orderManagementService)
        {
            _voucherRepository = new VoucherRepository();
            _orderManagementService = orderManagementService;
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
                FinalPrice = totalPrice
            };
            return voucher.Id;
        }

        //public void UpdateVoucher(IOrderManagementService orderManagementService)
        //{
        //    Voucher voucher = _voucherRepository.GetVoucher(orderId);
        //    decimal totalPrice = voucher.TotalPrice;
        //    decimal discount = 0;
        //    if (totalPrice > 100)
        //    {
        //        discount = totalPrice * 0.1m;
        //    }
        //    decimal finalPrice = totalPrice - discount;
        //    voucher.Discount = discount;
        //    voucher.FinalPrice = finalPrice;
        //    _voucherRepository.UpdateVoucher(voucher);
        //}
    }
}
