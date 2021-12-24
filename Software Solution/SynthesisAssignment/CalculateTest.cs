using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynthesisAssignment.MyClasses.Classes.MyHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.UnitTest
{
    [TestClass]
    public class CalculateTest
    {
        //Generate reference number of 6 digits
        [TestMethod]
        public void Generate_LessThanSevenDigitsTrue()
        {
            //Arrange
            int randomNumber = Calculate.Generate();

            //Act
            bool result = randomNumber < 1000000;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Generate_BiggerThanFiveDigitsTrue()
        {
            //Arrange
            int randomNumber = Calculate.Generate();

            //Act
            bool result = randomNumber > 99999;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Generate_LessThanSevenDigitsFalse()
        {
            //Arrange
            int randomNumber = Calculate.Generate();

            //Act
            bool result = randomNumber > 1000000;

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Generate_BiggerThanFiveDigitsFalse()
        {
            //Arrange
            int randomNumber = Calculate.Generate();

            //Act
            bool result = randomNumber < 99999;

            //Assert
            Assert.IsFalse(result);
        }


        //Calculate duration difference
        [TestMethod]
        public void CalculateDuration_BiggerThenZeroTrue()
        {
            //Arrange
            DateTime endDate = new DateTime(2021, 01, 15, 10, 00, 00);
            DateTime startDate = new DateTime(2021, 01, 10, 10, 00, 00);

            double duration = Calculate.CalculateDuration(endDate, startDate);

            //Act
            bool result = duration > 0;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CalculateDuration_BiggerThenZeroFalse()
        {
            //Arrange
            DateTime endDate = new DateTime(2021, 01, 15, 10, 00, 00);
            DateTime startDate = new DateTime(2021, 01, 10, 10, 00, 00);

            double duration = Calculate.CalculateDuration(endDate, startDate);

            //Act
            bool result = duration < 0;

            //Assert
            Assert.IsFalse(result);
        }

        //Round number to even
        [TestMethod]
        public void RoundNumberToEven_OddNumberToEvenTrue()
        {
            //Arrange
            int expected = 0;
            double oddDouble = 9.5;

            //Act
            int actual = Calculate.RoundNumberToEven(oddDouble) % 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RoundNumberToEven_EvenNumberToEvenTrue()
        {
            //Arrange
            int expected = 0;
            double evenDouble = 10.00;

            //Act
            int actual = Calculate.RoundNumberToEven(evenDouble) % 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Approve duration (duration must be bigger than 2hrs and lower than 2weeks)
        [TestMethod]
        public void ApproveDuration_DurationLessThanTwoHoursTrue()
        {
            //Arrange
            int duration = 1;

            //Act
            bool expected = Calculate.ApproveDuration(duration);

            //Assert
            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void ApproveDuration_DurationBiggerThanTwoWeeksTrue()
        {
            //Arrange
            int duration = 400;

            //Act
            bool expected = Calculate.ApproveDuration(duration);

            //Assert
            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void ApproveDuration_DurationIsValidTrue()
        {
            //Arrange
            int duration = 24;

            //Act
            bool expected = Calculate.ApproveDuration(duration);

            //Assert
            Assert.IsTrue(expected);
        }

        //calculate deposit
        [TestMethod]
        public void CalculateDeposit_HappyFlow()
        {
            //Arrange
            double expected = 399.4;

            //Act
            double actual = Calculate.CalculateDeposit(99.9, 1, 59.9, 5);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDeposit_WrongFlow()
        {
            //Arrange
            double expected = 399.4;

            //Act
            double actual = Calculate.CalculateDeposit(100, 1, 60.5, 4);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        //calculate Total price
        [TestMethod]
        public void CalculateTotalPrice_HappyFlow()
        {
            //Arrange
            double expected = 2500;

            //Act
            double actual = Calculate.CalculateTotalPrice(1000, 1500);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTotalPrice_WrongFlow()
        {
            //Arrange
            double expected = 2800;

            //Act
            double actual = Calculate.CalculateTotalPrice(1000, 1500);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        //date cannot be in the past
        [TestMethod]
        public void DateIsInPast_True()
        {
            //Arrange
            DateTime endDate = new DateTime(2000, 01, 15, 10, 00, 00);
            DateTime startDate = new DateTime(2000, 01, 10, 10, 00, 00);

            //Act
            bool actual = Calculate.DateIsInPast(endDate, startDate);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DateIsInPast_False()
        {
            //Arrange
            DateTime endDate = new DateTime(2030, 01, 15, 10, 00, 00);
            DateTime startDate = new DateTime(2030, 01, 10, 10, 00, 00);

            //Act
            bool actual = Calculate.DateIsInPast(endDate, startDate);

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
