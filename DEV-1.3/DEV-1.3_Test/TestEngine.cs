using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;
using System;

namespace DEV_1._3_Test
{
    [TestClass]
    public class TestEngine
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow(230, 5.7, "ZDADJB#34", "ADAR1234AD")]
        [DataRow(230, 5.7, "ZDADJB#34", "ADAR12%$AD")]
        [DataRow(230, 5.7, "ZDADJB#34", "ADAR1%^4AD")]
        public void TestInputValuesIfStringHasInvalidSymbols(int power, double capacity, string typeEngine, string serialNumber)
        {

            var actual = new Engine(power, capacity, typeEngine, serialNumber);


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(-250, 52.0)]
        [DataRow(250, -52.0)]
        [DataRow(-250, -52.0)]

        public void TestInputNegativeValue(int power, double capacity)
        {
            var actual = new Engine(power, capacity, "Petrol", "VDADR23asd");

        }

    }
    [TestClass]
    class TesTransmission
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
