using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Classes
{
    //check input messages
    public interface MessageICheckInput
    {
        public string EmptyFieldsErrorMessage();
        public string NumbersNotAllowedErrorMessage();
        public string LettersNotAllowedErrorMessage();
    }

    //check operation messages
    public interface MessageICheckInventory : MessageICheckInput
    {
        public string SuccessfulAddingMessage();
        public string UnsuccessfulAddingMessage();
        public string SuccessfulUpdateMessage();
        public string UnsuccessfulUpdateMessage();
    }

    //implement both interfaces in an abstarct class
    public abstract class MessageGuide : MessageICheckInventory
    {
        public abstract string EmptyFieldsErrorMessage();

        public virtual string LettersNotAllowedErrorMessage()
        {
            throw new NotImplementedException();
        }

        public virtual string NumbersNotAllowedErrorMessage()
        {
            throw new NotImplementedException();
        }

        public virtual string SuccessfulAddingMessage()
        {
            throw new NotImplementedException();
        }

        public virtual string SuccessfulUpdateMessage()
        {
            throw new NotImplementedException();
        }

        public virtual string UnsuccessfulAddingMessage()
        {
            throw new NotImplementedException();
        }

        public virtual string UnsuccessfulUpdateMessage()
        {
            throw new NotImplementedException();
        }
    }

    //methods implementation overriden
    public class MessageLoginGuide : MessageGuide
    {
        public override string EmptyFieldsErrorMessage()
        {
            return "Username and password are required fields";
        }

        public override string NumbersNotAllowedErrorMessage()
        {
            return "Username cannot contain numbers";
        }

        public string InvalidCredntialsErrorMessage()
        {
            return "Incorrect username or password";
        }
    }

    //methods implementation overriden
    public class MessageInventoryGuide : MessageGuide
    {
        public override string EmptyFieldsErrorMessage()
        {
            return "Please fill in all the required fields";
        }

        public override string LettersNotAllowedErrorMessage()
        {
            return "Cost, deposit, and quantity cannot be a number";
        }

        public override string SuccessfulAddingMessage()
        {
            return "New item is succussfully added to the inventory";
        }

        public override string UnsuccessfulAddingMessage()
        {
            return "Sorry, the new item is not added to the inventory.\nPlease try again";
        }

        public override string SuccessfulUpdateMessage()
        {
            return "Item is successfully updated";
        }

        public override string UnsuccessfulUpdateMessage()
        {
            return "Sorry, item was not updated.\nPlease try again";
        }
    }
}
