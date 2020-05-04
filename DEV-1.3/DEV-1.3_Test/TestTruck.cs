using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;
namespace DEV_1._3_Test
{
    [TestClass]
    public class TestTruck
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow("Electrcic", "123$123")]
        [DataRow("Elec$tric", "123123")]
        [DataRow("Ele#ctric", "123d%")]
        public void TestInputInvalidString(string model, string make)
        {
            var actual = new Truck(new Engine(typeEngine.Hybrid , 500, 8.7,"NHFAR234DAD"),
                                      new Transmission(typeOfTransmission.Mechanical, 12, "DAF"),
                                      new Chassis(8, "NGD5412BND", 20000),
                                      model, "White", make);
        }
    }
}
