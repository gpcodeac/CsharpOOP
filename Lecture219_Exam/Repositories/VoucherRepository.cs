using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class VoucherRepository : IVoucherRepository
    {

        private List<Voucher> _vouchers = new List<Voucher>();

        public IEnumerable<Voucher> GetAllVouchers()
        {
            return _vouchers;
        }

        public Voucher GetVoucher(int id)
        {
            return _vouchers.FirstOrDefault(v => v.Id == id);
        }

        public void AddVoucher(Voucher voucher)
        {
            _vouchers.Add(voucher);
        }

        public void UpdateVoucher(Voucher voucher)
        {
            int ix = _vouchers.FindIndex(v => v.Id == voucher.Id);
            if (ix != -1)
            {
                _vouchers[ix] = voucher;
            }
        }

        public void DeleteVoucher(int id)
        {
            _vouchers.Remove(_vouchers.FirstOrDefault(v => v.Id == id));
        }

    }
}
