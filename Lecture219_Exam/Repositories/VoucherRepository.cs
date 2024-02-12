using System.Text.Json;
using Lecture219_Exam.Models;
using Lecture219_Exam.Repositories.Interfaces;

namespace Lecture219_Exam.Repositories
{
    internal class VoucherRepository : IVoucherRepository
    {

        private readonly List<Voucher> _vouchers = new List<Voucher>();

        public VoucherRepository()
        {
            var jsonvouchers = File.ReadAllText(@"../../../Data/Vouchers.json");
            _vouchers = JsonSerializer.Deserialize<List<Voucher>>(jsonvouchers);
        }

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
            Save();
        }

        public void UpdateVoucher(Voucher voucher)
        {
            int ix = _vouchers.FindIndex(v => v.Id == voucher.Id);
            if (ix != -1)
            {
                _vouchers[ix] = voucher;
            }
            Save();
        }

        public void DeleteVoucher(int id)
        {
            _vouchers.Remove(_vouchers.FirstOrDefault(v => v.Id == id));
            Save();
        }

        private void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsonvouchers = JsonSerializer.Serialize(_vouchers, options);
            File.WriteAllText(@"../../../Data/Vouchers.json", jsonvouchers);
        }

    }
}
