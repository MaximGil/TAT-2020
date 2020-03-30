using System;


namespace DEV_1._4
{
  public  class Drone : IFlyable
    {
        readonly static double intervalTime = 0.16666666667;
        readonly static double waitingTime = 0.0166666667;
        Coordinate startPoint;
        private double speed = Randomizer.rnd.Next(minSpeed, maxSpeed);
        readonly static int minSpeed = 5;
        readonly static int maxSpeed = 35;
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
        /// Getting drone flight time
        /// </summary>
        /// <param name="inputCoordinate">Arrival point</param>
        /// <returns>return flying time</returns>
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
            //int countInterval = (int)(time / intervalTime); // second variant 
            //double time2 = time;
            //time2 += countInterval * waitingTime;
            return time;

        }
    }
}
