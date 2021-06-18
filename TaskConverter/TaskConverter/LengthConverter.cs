

using System;

namespace TaskConverter
{
    class LengthConverter : IConverter
    {
        const double COFFICIENT_CONVERT_TO_POUND = 3.28084;
        const double COFFICIENT_CONVERT_TO_METERS = 0.3048;

        public double Convert(double value, string direction)
        {
            if (direction == "MP")
            {
                return ConvertMetersToPounds(value);
            }
            else if(direction == "PM")
            {
                return ConvertPoundsToMeters(value);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public double ConvertMetersToPounds(double value) => value * COFFICIENT_CONVERT_TO_POUND;
        public double ConvertPoundsToMeters(double value) => value * COFFICIENT_CONVERT_TO_METERS;
    }
}

