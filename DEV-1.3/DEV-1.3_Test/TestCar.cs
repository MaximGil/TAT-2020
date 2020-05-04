using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;
namespace DEV_1._3_Test
{
    [TestClass]
    public class TestCar
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow("123ADvasdaq213", "123dasdsagf$123")]
        [DataRow("123ADvas$daq213", "123dasdsagf123")]
        [DataRow("123ADvasda#q213", "123dasdsagf123")]
        public void TestInputInvalidString(string model, string number)
        {
            var carEngine = new Engine(typeEngine.Diesel,400, 5.7, "ANV5642BC2");
            var carTransmission = new Transmission(typeOfTransmission.Combined, 8, "MercedesBenz");
            var carChassis = new Chassis(4, "BNF232353GH", 2345);
            var actual = new Car(carEngine, carTransmission, carChassis, model, number, "green");

        }
    
    }
}
