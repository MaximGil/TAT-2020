using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;
namespace DEV_1._3_Test
{
    [TestClass]
    public class TestBus
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow(45, "123$123")]
        [DataRow(45, "123123")]
        [DataRow(45, "123d%")]
        public void TestInputInvalidString(int numberOfSeats, string number)
        {
            var actual = new Bus(new Engine(typeEngine.Electric,200, 4.0, "12BNLAD23"),
                                   new Transmission(typeOfTransmission.Combined, 6, "Ford"),
                                   new Chassis(6, "B768CD0", 2760),
                                   numberOfSeats, number, 90);

        }
    }
}
