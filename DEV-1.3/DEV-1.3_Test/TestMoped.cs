﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;
namespace DEV_1._3_Test
{
    [TestClass]
    public class TestMoped
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow("Electrcic", "123$123")]
        [DataRow("Elec$tric", "123123")]
        [DataRow("Ele#ctric", "123d%")]
        public void TestInputInvalidString(string model, string make)
        {
            var actual = new Moped(model, "White", make,new Engine(typeEngine.Petrol,500, 8.7, "NHFAR234DAD"),
                                      new Transmission(typeOfTransmission.Combined, 12, "DAF"),
                                      new Chassis(8, "NGD5412BND", 20000));
        }
    }
}
