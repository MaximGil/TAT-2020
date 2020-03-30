using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._4;

namespace Test_DEV_1._4
{
    [TestClass]
    public class TestBird
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(200.0, 200.0, 200.0)]
        public void CheckNullSpeed(double X, double Y, double Z)
        {
            var coordinate = new Coordinate(X, Y, Z);
            var expeceted = new Bird(new Coordinate(1.0, 1.0, 1.0)).GetFlyTime(coordinate);
        }

    }
}
