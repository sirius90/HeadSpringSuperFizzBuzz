using FizzBuzzLibrary;
using FizzBuzzLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UserIntegersClassicFizzBuzz()
        {
            //Arrange
            var userInts = new List<int>() { 3, 8, 10, 2, 5, 18, 20, 15 };

            var listTokens = new List<DivisorToken>();

            var divisorToken1 = new DivisorToken(3, "Fizz");
            var divisorToken2 = new DivisorToken(5, "Buzz");

            listTokens.Add(divisorToken1);
            listTokens.Add(divisorToken2);

            var superFizzBuzz = new SuperFizzBuzz(null,userInts,listTokens);

            //Act
            var result = superFizzBuzz.FizzBuzz();

            //Assert
            Assert.AreEqual("FizzBuzz", result[7]);

        }

        [TestMethod]
        public void UserIntegersUserTokenized()
        {
            //Arrange
            var userInts = new List<int>() { 3, 8, 10, 2, 5, 18, 38, 20, 15, 21 };

            var listTokens = new List<DivisorToken>();

            var divisorToken1 = new DivisorToken(3, "Fizz");
            var divisorToken2 = new DivisorToken(7, "Buzz");
            var divisorToken3 = new DivisorToken(38, "Bazz");

            var superFizzBuzz = new SuperFizzBuzz(null, userInts, listTokens);

            listTokens.Add(divisorToken1);
            listTokens.Add(divisorToken2);
            listTokens.Add(divisorToken3);

            //Act
            var result = superFizzBuzz.FizzBuzz();

            //Assert
            Assert.AreEqual("Fizz", result[0]);
            Assert.AreEqual("Bazz", result[6]);
            Assert.AreEqual("FizzBuzz", result[9]);
        }

        [TestMethod]
        public void SuperFizzBuzzTokenized()
        {
            //Arrange
            var listTokens = new List<DivisorToken>();

            var divisorToken1 = new DivisorToken(3, "Fizz");
            var divisorToken2 = new DivisorToken(7, "Buzz");
            var divisorToken3 = new DivisorToken(38, "Bazz");

            listTokens.Add(divisorToken1);
            listTokens.Add(divisorToken2);
            listTokens.Add(divisorToken3);

            var superFizzBuzz = new SuperFizzBuzz(new IntRange(-12, 145), null, listTokens);

            //Act
            var result = superFizzBuzz.FizzBuzz();

            //Assert
            Assert.AreEqual("Fizz", result[0]);
            Assert.AreEqual("Buzz", result[5]);
            Assert.AreEqual("FizzBuzz", result[33]);
            Assert.AreEqual("Bazz", result[51]);
        }

        [TestMethod]
        public void ClassicFizzBuzz()
        {
            //Arrange
            var listTokens = new List<DivisorToken>();

            var divisorToken1 = new DivisorToken(3, "Fizz");
            var divisorToken2 = new DivisorToken(5, "Buzz");

            listTokens.Add(divisorToken1);
            listTokens.Add(divisorToken2);

            var classicFizzBuzz = new SuperFizzBuzz(new IntRange(1, 100),null,listTokens);

            //Act
            var result = classicFizzBuzz.FizzBuzz();

            //Assert
            Assert.AreEqual("Fizz", result[2]);
            Assert.AreEqual("Buzz", result[4]);
            Assert.AreEqual("FizzBuzz", result[14]);
        }
    }
}
