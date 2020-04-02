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
        [DataRow("Electrcic", "123$123")]
        [DataRow("Elec$tric", "123123")]
        [DataRow("Ele#ctric", "123d%")]
        public void TestInputInvalidString(string model, string number)
        {
            var actual = new Bus(new Engine(typeEngine.Electric,200, 4.0, "12BNLAD23"),
                                   new Transmission(typeOfTransmission.Combined, 6, "Ford"),
                                   new Chassis(6, "B768CD0", 2760),
                                   model, number, 90);

        }
    }
}
