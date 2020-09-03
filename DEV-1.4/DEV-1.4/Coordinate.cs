using System;
namespace DEV_1._4
{
    public struct Coordinate
    {
        private double x;
        private double y;
        private double z;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = CheckValue(value);
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = CheckValue(value);
            }
        }
        public double Z
        {
            get { return z; }
            set
            {
                y = CheckValue(value);
            }
        }
        public Coordinate(double x, double y, double z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double GetDistance(Coordinate coordinate)
        {
            double result = Math.Pow(Math.Abs(this.X - coordinate.X), 2) + Math.Pow(Math.Abs(this.Y - coordinate.Y), 2) + Math.Pow(Math.Abs(this.Z - coordinate.Z), 2);
            result = Math.Sqrt(result);
            return result;
        }
        private double CheckValue(double value)
        {
            if (value < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else return value;
        }
    }

}
