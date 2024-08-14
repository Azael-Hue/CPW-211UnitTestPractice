using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            double expectedTotal = num1 + num2;

            // Act
            double returnValue = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedTotal, returnValue);
        }

        [TestMethod]
        [DataRow(5, 12.5)]
        [DataRow(0, 100)]
        [DataRow(-1.5, -10)]
        [DataRow(8, -10)]
        public void Multiply_TwoNumbers_ReturnsProduct(double value1, double value2)
        {
            // Arrange
            double expectedTotal = value1 * value2;

            // Act
            double returnValue = SimpleMath.Multiply(value1, value2);

            // Assert
            Assert.AreEqual(expectedTotal, returnValue);
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(0, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException( double value1, double value2 )
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            // Assert => Act
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(value1, value2));
            
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(10, 99)]
        [DataRow(-1, -10)]
        [DataRow(7, 25)]
        public void Divide_TwoNumbers_ReturnTotal( double value1, double value2 )
        {
            // Arrange
            

            // Act

            // Assert
        }

        // TODO: Test subtract method with two valid numbers
    }
}