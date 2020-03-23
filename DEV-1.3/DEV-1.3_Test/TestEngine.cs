using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using DEV_1._3;
using Assert = NUnit.Framework.Assert;
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
}
