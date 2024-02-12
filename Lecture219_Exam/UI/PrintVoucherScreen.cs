using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.Services;
using Lecture219_Exam.Utils;
using Lecture219_Exam.Services.Interfaces;



namespace Lecture219_Exam.UI
{
    internal class PrintVoucherScreen : IScreen
    {
        private readonly IVoucherManagementService _voucherManagementService = new VoucherManagementService();

        public IScreen Print()
        {
            while(true)
            {
                string text = $"""
                Enter Voucher ID to print the voucher:

                >
                """;
                AppMessage.Display(text);
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int voucherId))
                {
                    string details = _voucherManagementService.GetVoucherDetails(voucherId);
                    AppMessage.Display(details, hold: true);
                    return new HomeScreen();
                }
                else
                {
                    AppMessage.Display("Invalid input. Please try again.", ErrCode.Warning, true);
                }
            }
        }
    }
}
