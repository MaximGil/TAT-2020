

using System;

namespace DEV_1._4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                var pointOfArrival = new Coordinate(3000.0, 3000.0, 3000.0);
                var bird = new Bird(new Coordinate(1.0, 1.0, 1.0));
                //bird.FlyTo(pointOfArrival);
                Console.WriteLine(bird.GetFlyTime(pointOfArrival));
                var plane = new Plane(new Coordinate(1.0, 1.0, 1.0));
                Console.WriteLine(plane.GetFlyTime(pointOfArrival));
                var drone = new Drone(new Coordinate(2.0, 2.0, 2.0));
                Console.WriteLine(drone.GetFlyTime(pointOfArrival));
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
