using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._4;
namespace Test_DEV_1._4
{
    [TestClass]
    public class TestCoordinate
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(1.0, 1.0, -1.0)]
        [DataRow(1.0, -1.0, 1.0)]
        [DataRow(-1.0, 1.0, 1.0)]
        public void CheckInputValues(double x, double y, double z)
        {
            var coordinate = new Coordinate(x, y, z);
        }
    }
}
