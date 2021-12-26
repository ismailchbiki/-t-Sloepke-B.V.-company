using SynthesisAssignment.MyClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services.DALInterfaces
{
    public interface IProcessQuote
    {
        //quote payments
        public bool SettleDeposit(Quote quote);
        public bool SettlePayment(Quote quote);
    }
}
