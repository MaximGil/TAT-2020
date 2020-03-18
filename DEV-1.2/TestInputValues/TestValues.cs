using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._2;

namespace TestInputValues
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null, 2)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckInputNullString(string inputString, int baseSystem)
        {
            var converter = new Converter(inputString, baseSystem);
            var actual = converter.ConvertToAnotherSystem();
            var expected = new ArgumentNullException();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("", 2)]
        [DataRow("abcd", 10)]
        [DataRow("-123", 16)]
        [ExpectedException(typeof(FormatException))]
        public void CheckInputEmptyStringAndDigitStringOrNegativeNumber(string inputString, int baseSystem)
        {
            var converter = new Converter(inputString, baseSystem);
            var actual = converter.ConvertToAnotherSystem();
            var expected = new FormatException();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("123", 1)]
        [DataRow("123", 23)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CheckInputBaseSystemLess2andBaseSystemMore20(string inputString, int baseSystem)
        {
            var converter = new Converter(inputString, baseSystem);
            var actual = converter.ConvertToAnotherSystem();
            var expected = new IndexOutOfRangeException();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("12321325412312412", 2)]
        [ExpectedException(typeof(OverflowException))]
        public void CheckInputMaxIntValue(string inputString, int baseSystem)
        {
            var converter = new Converter(inputString, baseSystem);
            var actual = converter.ConvertToAnotherSystem();
            var expected = new OverflowException();
            Assert.AreEqual(actual, expected);
        }
    }
}
