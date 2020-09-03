using System;


namespace DEV_1._4
{
  public  class Drone : IFlyable
    {
        readonly static double intervalTime = 0.16666666667; // in hours
        readonly static double waitingTime = 0.0166666667; // in hours
        Coordinate startPoint;
        private double speed = Randomizer.rnd.Next(minSpeed, maxSpeed);
        readonly static int minSpeed = 5; // km/h
        readonly static int maxSpeed = 35; // km/h
        double distance;
        double time;

        public Drone(Coordinate startPoint)
        {
            this.startPoint = startPoint;
           
        }
        /// <summary>
        /// Drone arrival infomation
        /// </summary>
        /// <param name="inputCoordinate">Arrival point</param>
        public void FlyTo(Coordinate inputCoordinate)
        {
            if (this.startPoint.X == inputCoordinate.X && startPoint.Y == inputCoordinate.Y && this.startPoint.Z == inputCoordinate.Z)
            {
                Console.WriteLine("Arrived!");
            }
            else
            {
                Console.WriteLine("Not arrived");
            }
        }
        /// <summary>
        /// Getting drone flight time in hours
        /// </summary>
        /// <param name="inputCoordinate">Arrival point</param>
        /// <returns>return flying time </returns>
        public double GetFlyTime(Coordinate inputCoordinate)
        {
            distance = this.startPoint.GetDistance(inputCoordinate);
            if (distance >= 1000)
            {
                throw new IndexOutOfRangeException();
            }
            time = distance / speed;           // get flying time without breaks 
            for (double i = intervalTime; i < time; i += intervalTime) // check all breaks intervals and add to the total time
            {
                time += waitingTime;
            }

            return time;

        }
    }
}
