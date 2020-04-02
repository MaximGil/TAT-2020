

using System;

namespace DEV_1._4
{
    public class Bird : IFlyable
    {
        Coordinate startPosition;
        double _speed = Randomizer.rnd.Next(minSpeed, maxSpeed);
        readonly static int minSpeed = 0;
        readonly static int maxSpeed = 20;

        public Bird(Coordinate coordinate)
        {
            this.startPosition = coordinate;
            if (_speed == 0)
            {
                throw new ArgumentNullException();
            }
            


        }
        /// <summary>
        /// bird arrival information
        /// </summary>
        /// <param name="inputCoordinate">Arrival point</param>
        public void FlyTo(Coordinate inputCoordinate)
        {
            if (this.startPosition.X == inputCoordinate.X && this.startPosition.Y == inputCoordinate.Y && this.startPosition.Z == inputCoordinate.Z)
            {
                Console.WriteLine("Arrived!");
            }
            else
            {
                Console.WriteLine("Not arrived");
            }
        }
        /// <summary>
        /// the time that the bird flew. Got it by simply dividing the distance by speed
        /// </summary>
        /// <param name="inputCoordinate">Arrival point</param>
        /// <returns>Returns flight time</returns>
        public double GetFlyTime(Coordinate inputCoordinate)
        {
            if (this.startPosition.GetDistance(inputCoordinate) == 0 )
        {
                throw new ArgumentNullException();
        }
        
            double time = this.startPosition.GetDistance(inputCoordinate) / _speed;
            return time;
        }

    }
}
