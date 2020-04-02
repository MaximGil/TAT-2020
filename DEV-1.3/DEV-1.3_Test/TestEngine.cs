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
        [DataRow(230, 5.7, "ADAR1234AD")]
        [DataRow(230, 5.7, "ADAR12%$AD")]
        [DataRow(230, 5.7, "ADAR1%^4AD")]
        public void TestInputValuesIfStringHasInvalidSymbols(int power, double capacity, string serialNumber)
        {

            var actual = new Engine(typeEngine.Hybrid,power, capacity, serialNumber);


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(-250, 52.0)]
        [DataRow(250, -52.0)]
        [DataRow(-250, -52.0)]

        public void TestInputNegativeValue(int power, double capacity)
        {
            var actual = new Engine(typeEngine.Electric,power, capacity, "VDADR23asd");

        }

    }
    [TestClass]
    class TesTransmission
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

        public void TestInputNegativeValues( int numberOfGears, string manufacturer)
        {
            var actual = new Transmission(typeOfTransmission.Hydrovolume, numberOfGears, manufacturer);
        }
    }
}
