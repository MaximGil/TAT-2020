using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestInputString
{
    [TestClass]
    public class InputString
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InputAnotherStringWhenNull()
        {
            string inputString = null;
            var sequenceLenght = new SequenceLength(inputString);
            var actual = sequenceLenght.SequenceGetCounter();
            var expected = new ArgumentNullException();
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        [DataRow("", 0)]
        [DataRow("abcdefg", 7)]
        [DataRow("aaaaaaaaaaaaabfaaaaaaaaa", 3)]
        public void InputStringDifferentLenghtAndDifeerenceSequences(string inputString, int expected)

        {
            var sequenceLen = new SequenceLength(inputString);
            var actual = sequenceLen.SequenceGetCounter();
                 Assert.AreEqual(actual, expected);
        }
    }
}
