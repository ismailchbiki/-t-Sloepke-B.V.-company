﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Classes
{
    public static class Verify
    {

        //check if text contains numbers
        public static bool ContainNumbers(string text)
        {
            bool status = false;
            bool containNumbers = Regex.IsMatch(text, @"\d");
            if (containNumbers)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        //public bool ContainNumbers(string text)
        //{
        //    if (text.All(char.IsDigit))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //check if text contains letters

        public static bool ContainLetters(string text)
        {
            bool status = false;

            bool containLetters = Regex.IsMatch(text, @"^[\p{L}\s]+$");
            if (!containLetters)
            {
                status = false;
            }
            else
            {
                status = true;
            }

            return status;
        }

        //check if input is number or text
        //public bool InputIsInt(string text)
        //{
        //    int result = 0;
        //    if (int.TryParse(text, out result))
        //    {
        //        //if the input is an int
        //        return true;
        //    }

        //    //if the input is a text
        //    return false;
        //}

        //validate email

        public static bool IsEmail(string email)
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
