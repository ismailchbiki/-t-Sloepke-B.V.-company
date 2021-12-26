using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;
using SynthesisAssignment.Services.DALInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class QuotePaymentManagement : IQuotePayManagement
    {
        IProcessQuote _processQuoteDA;

        //constructor to inject needed service classes
        public QuotePaymentManagement(IProcessQuote processquoteDA)
        {
            this._processQuoteDA = processquoteDA;
        }

        public bool SettleDeposit(Quote quote)
        {
            bool status = false;

            //settle deposit
            if (_processQuoteDA.SettleDeposit(quote))
            {
                status = true;
            }

            return status;
        }
        public bool SettlePayment(Quote quote)
        {
            bool status = false;

            //settle deposit
            if (_processQuoteDA.SettlePayment(quote))
            {
                status = true;
            }

            return status;
        }
    }
}
