using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using DEV_1._3;
using Assert = NUnit.Framework.Assert;
using System;

namespace DEV_1._3_Test
{
    [TestClass]
    class TestTransmission
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow("ZDADJB#34", 8, "ADAR1234AD")]
        [DataRow("ZDADJB#34", 12, "ADAR12%$AD")]
        [DataRow("ZDADJB#34", 12, "ADAR1%^4AD")]
        public void TestInputValuesIfStringHasInvalidSymbols(string typeOfTransmission, int numberOfGears, string manufacturer)
        {
            var actual = new Transmission(typeOfTransmission, numberOfGears, manufacturer);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow("ZDADJB#34", -1, "ADAR1234AD")]

        public void TestInputNegativeValues(string typeOfTransmission, int numberOfGears, string manufacturer)
        {
            var actual = new Transmission(typeOfTransmission, numberOfGears, manufacturer);
        }
    }
}
