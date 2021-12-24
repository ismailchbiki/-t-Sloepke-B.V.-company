using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class ProcessQuotePayment
    {
        DALQuote dalQuote = new DALQuote();

        public bool SettleDeposit(Quote quote)
        {
            bool status = false;

            //settle deposit
            if (dalQuote.SettleDeposit(quote))
            {
                status = true;
            }

            return status;
        }
        public bool SettlePayment(Quote quote)
        {
            bool status = false;

            //settle deposit
            if (dalQuote.SettlePayment(quote))
            {
                status = true;
            }

            return status;
        }
    }
}
