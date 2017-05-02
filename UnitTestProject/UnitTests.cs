using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestGoodAddIntegers()
        {
            // Arrange
            ClassUnderTest cut = new ClassUnderTest();

            // Act
            int result = cut.GoodAddIntegers(3, 4); // passes

            // Assert
            Assert.AreEqual(result, 3 + 4);
        }
        [TestMethod]
        public void TestBadAddIntegers()
        {
            // Arrange
            ClassUnderTest cut = new ClassUnderTest();

            // Act
            int result = cut.BadAddIntegers(3, 4); // fails

            // Assert
            Assert.AreEqual(result, 3 + 4);
        }
    }
}
