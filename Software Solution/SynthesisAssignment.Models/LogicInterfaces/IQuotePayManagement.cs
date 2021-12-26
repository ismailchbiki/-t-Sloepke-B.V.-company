using SynthesisAssignment.MyClasses.Classes;

namespace SynthesisAssignment.Models.Administration
{
    public interface IQuotePayManagement
    {
        bool SettleDeposit(Quote quote);
        bool SettlePayment(Quote quote);
    }
}