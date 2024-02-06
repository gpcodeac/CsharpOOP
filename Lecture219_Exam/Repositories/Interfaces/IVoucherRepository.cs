using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Repositories.Interfaces
{
    internal interface IVoucherRepository
    {
        public IEnumerable<Voucher> GetAllVouchers();
        public Voucher GetVoucher(int id);
        public void AddVoucher(Voucher voucher);
        public void UpdateVoucher(Voucher voucher);
        public void DeleteVoucher(int id);

    }
}
