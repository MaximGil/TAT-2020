using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;

namespace DEV_1._3_Test
{
    [TestClass]
    class TestTransmission
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow(8, "ADAR1234AD")]
        [DataRow(12, "ADAR12%$AD")]
        [DataRow(12, "ADAR1%^4AD")]
        public void TestInputValuesIfStringHasInvalidSymbols(int numberOfGears, string manufacturer)
        {
            var actual = new Transmission(typeOfTransmission.Electrical, numberOfGears, manufacturer);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(-1, "ADAR1234AD")]

        public void TestInputNegativeValues(int numberOfGears, string manufacturer)
        {
            var actual = new Transmission(typeOfTransmission.Hydrovolume, numberOfGears, manufacturer);
        }
    }
}