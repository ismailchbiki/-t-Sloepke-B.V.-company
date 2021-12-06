using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Classes
{
    public class GuidingMessages
    {

        public string EmptyCredentialsFieldsError()
        {
            return "Username and password are required fields";
        }


        public string NumbersNotAllowedError()
        {
            return "Username cannot contain numbers";
        }


        public string InvalidCredentialsError()
        {
            return "Incorrect username or password";
        }


        public string EmptyFieldsError()
        {
            return "Please fill in all the fields"; ;
        }


        public string GearFieldsError()
        {
            return "Costs, Deposit and Quantity must be a valid number";
        }

        public string SuccessfulSave()
        {
            return "Item successfully added to the inventory";
        }

        public string UnsuccessfulSave()
        {
            return "Error:\nYou cannot add a new item that already exists";
        }

        public string SuccessfulUpdate()
        {
            return "Item successfully updated in the inventory";
        }

        public string UnsuccessfulUpdate()
        {
            return "Error:\nItem didn't get updated. Please make sure you provide a unique name for the type";
        }
    }
}
