using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes.MyHelpers
{
    public static class Calculate
    {

        //generate random number for quote reference
        public static int Generate()
        {
            Random number = new ();

            int num = number.Next(100000, 999999);
            return num;
        }

        //calculate time difference between 2 dates
        public static double CalculateDuration(DateTime endDate, DateTime startDate)
        {

            //duration calculation per hours between 2 dates
            double diff = (endDate - startDate).TotalHours;
            return diff;
        }

        //MidpointRounding.ToEven for duration
        public static int RoundNumberToEven(double diff)
        {
            int durationHours = Convert.ToInt32(Math.Round(diff, 0, MidpointRounding.ToEven));
            return durationHours;
        }

        //time difference must meet these criteria
        public static bool ApproveDuration(int duration)
        {
            bool status = true;
            if (duration < 2 || duration > 336)
            {
                status = false;
            }

            return status;
        }

        //calculate total deposit
        public static double CalculateDeposit(double boatDeposit,
            int boatQuantity, double itemDeposit, int itemQuantity)
        {
            double output;
            output = (boatDeposit * boatQuantity) + (itemDeposit * itemQuantity);

            return output;
        }

        //calculate total price
        public static double CalculateTotalPrice(double boatPrice, double itemPrice)
        {
            double value;
            value = boatPrice + itemPrice;

            return value;
        }

        public static bool DateIsInPast(DateTime endDate, DateTime startDate)
        {
            bool status = true;

            if (DateTime.Compare(startDate, DateTime.Now) < 0
               || DateTime.Compare(endDate, DateTime.Now) < 0)
            {
                status = false;
            }

            return status;
        }
    }
}
