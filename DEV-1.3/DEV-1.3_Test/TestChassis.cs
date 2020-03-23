using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._3;
namespace DEV_1._3_Test
{
    [TestClass]
    public class TestChassis
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow("12asdafa#dad")]
        public void TestInputInvalidValuesInString(string numberOfChassis)
        {
            var actual = new Chassis(23, numberOfChassis, 2340);
        }
    }
}
