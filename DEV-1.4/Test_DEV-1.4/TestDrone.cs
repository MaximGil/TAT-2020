using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._4;
namespace Test_DEV_1._4
{
    [TestClass]
    public class TestDrone
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(3000.0, 3000.0, 3000.0)]
        public void CheckDistanceTest(double x,double y,double z)
        {
            var arrivalPoint = new Coordinate(x, y, z);
            var drone = new Drone(new Coordinate(1.0, 1.0, 1.0)).GetFlyTime(arrivalPoint);

        }
    }
}
