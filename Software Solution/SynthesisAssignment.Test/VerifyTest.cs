using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynthesisAssignment.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.UnitTest
{
    [TestClass]
    public class VerifyTest
    {
        //check if input contain numbers
        [TestMethod]
        public void ContainNumbers_True()
        {
            //Arrange
            string input = "Username1";

            //Act
            bool actual = Verify.ContainNumbers(input);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainNumbers_False()
        {
            //Arrange
            string input = "Username";

            //Act
            bool actual = Verify.ContainNumbers(input);

            //Assert
            Assert.IsFalse(actual);
        }

        //check if input contain letters
        [TestMethod]
        public void ContainLetters_True()
        {
            //Arrange
            string input = "Text";

            //Act
            bool actual = Verify.ContainLetters(input);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainLetters_False()
        {
            //Arrange
            string input = "123";

            //Act
            bool actual = Verify.ContainLetters(input);

            //Assert
            Assert.IsFalse(actual);
        }

        //check if input is a valid email
        [TestMethod]
        public void IsEmail_True()
        {
            //Arrange
            string input = "username@email.com";

            //Act
            bool actual = Verify.IsEmail(input);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmail_False()
        {
            //Arrange
            string input = "username.email.com";

            //Act
            bool actual = Verify.IsEmail(input);

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
