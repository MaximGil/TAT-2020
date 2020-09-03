﻿using System;


namespace DEV_1._4
{
    public class Plane : IFlyable
    {
        Coordinate coordinate;
        private double speed = 200.0;
        readonly static double intervalDistance = 10.0; // km
        readonly static double increaseSpeed = 10.0; // km/h
        readonly static double maxAvailableSpeed = 500; // km/h

        public Plane(Coordinate coordinate)
        {
            this.coordinate = coordinate;

        }

        public void FlyTo(Coordinate inputCoordinate)
        {
            if (this.coordinate.X == inputCoordinate.X && coordinate.Y == inputCoordinate.Y && this.coordinate.Z == inputCoordinate.Z)
            {
                Console.WriteLine("Arrived!");
            }
            else
            {
                Console.WriteLine("Not arrived");
            }
        }
        /// <summary>
        /// Getting airplane flight time in hours
        /// </summary>
        /// <param name="inputCoordinate">Arrival point</param>
        /// <returns>return flying time</returns>
        public double GetFlyTime(Coordinate inputCoordinate)
        {
            double distance = this.coordinate.GetDistance(inputCoordinate);
            double time = 0;
            for (double i = intervalDistance; i < distance; i += intervalDistance) //in cycle check how many intervals when speed increase
            {                                                                       // and  get the time for which plane flew this interval 
                time += intervalDistance / speed;
                speed += increaseSpeed;
            }
            if (speed >= maxAvailableSpeed)
            {
                throw new IndexOutOfRangeException();
            }
            Console.WriteLine(speed);
            double finalDistance = distance % intervalDistance; // count and add time that is not included in the cycle
            time += finalDistance / speed;
            return time;

        }
    }
}
