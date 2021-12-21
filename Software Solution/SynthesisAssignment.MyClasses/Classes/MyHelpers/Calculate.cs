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
        public static int CalculateDuration(DateTime endDate, DateTime startDate)
        {

            //duration calculation per hours between 2 dates
            double diff = (endDate - startDate).TotalHours;

            //MidpointRounding.ToEven for duration
            int durationHours = Convert.ToInt32(Math.Round(diff, 0, MidpointRounding.ToEven));

            return durationHours;
        }

        //to make duration an even number
        public static int DurationMultipleOfTwo(int duration)
        {
            //to round manually odd numbers for multiple of 2 hours
            double reminder = duration % 2;
            if (reminder != 0)
            {
                duration += 1;
            }

            return duration;
        }

        //time difference must meet these criteria
        public static bool ApproveDuration(int duration)
        {

            if (duration < 2 || duration > 336)
            {
                return false;
            }

            return true;
        }

        //calculate total deposit
        public static double CalculateDeposit(double boatDeposit,
            int boatQuantity, double itemDeposit, int itemQuantity)
        {
            double output;
            output = (boatDeposit * boatQuantity) + (itemDeposit * itemQuantity);

            return output;
        }
    }
}
