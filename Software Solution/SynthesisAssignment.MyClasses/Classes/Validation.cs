using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Classes
{
    public class Validation
    {

        //check if text contains numbers
        public bool ContainNumbers(string text)
        {
            bool containNumbers = Regex.IsMatch(text, @"^[\p{N}\s]+$");
            if (!containNumbers)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //check if text contains letters
        public bool ContainLetters(string text)
        {
            bool containLetters = Regex.IsMatch(text, @"^[\p{L}\s]+$");
            if (!containLetters)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //check if input is number or text
        public bool InputIsInt(string text)
        {
            int result = 0;
            if (int.TryParse(text, out result))
            {
                //if the input is an int
                return true;
            }

            //if the input is a text
            return false;
        }


        //validate email
        public bool IsEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"[a-z]+@+[a-z]+.com$");
            if (!isEmail)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
