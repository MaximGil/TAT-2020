using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._4;
namespace Test_DEV_1._4
{
    [TestClass]
    public class TestPlane
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(9000.0,9000.0,9000.0)]
        public void CheckSpeenMoreThan_500(double x,double y, double z)
        {
            var arrivalPoint = new Coordinate(x, y, z);
            var plane = new Plane(new Coordinate(1.0, 1.0, 1.0)).GetFlyTime(arrivalPoint);
        }
    }
}
