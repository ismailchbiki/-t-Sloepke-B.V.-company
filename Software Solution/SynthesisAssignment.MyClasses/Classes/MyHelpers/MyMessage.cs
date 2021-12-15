using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public static class MyMessage
    {
        //login
        public static string UsernameRequired = "Username is a required field";
        public static string PasswordRequired = "Password is a required field";
        public static string UsernameNumbersUnallowed = "Username cannot contain numbers";
        public static string IncorrectCredentials = "Incorrect username or password";

        //inventory
        public static string AllfieldsAreRequired = "Please fill in all the required fields";
        public static string GearInfoLettersUnallowed = "Cost, deposit, and quantity cannot be a letter";
        public static string SuccessfulSaving = "New item is succussfully added to the inventory";
        public static string UnsuccessfulSaving = "Sorry, the new item is not added to the inventory.\nPlease try again";
        public static string SuccessfulUpdate = "The item is succussfully updated";
        public static string UnsuccessfulUpdate = "Item was not updated successfully.\nPlease try again";
    }
}
