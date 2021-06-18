
using System;
namespace TaskConverter
{
    class TemperatureConverter : IConverter
    {

        const double COFFICIENT_CONVERT_TO_FAHRENHEIT = 9.0 / 5;
        const double COFFICIENT_CONVERT_TO_CELSIUS = 5.0 / 9;
        const double COFFICIENT_CONVERT_TEMPERATURE = 32;

        public double Convert(double value, string direction)
        {
           if(direction == "CF")
            {
                return ConvertCelsiusToFahrenheit(value);
            }
           else if(direction == "FC")
            {
                return ConvertFahrenheitToCelsius(value);
            }
     else
            {
                throw new ArgumentException();
            }
        }

        public double ConvertCelsiusToFahrenheit(double value) => (value * COFFICIENT_CONVERT_TO_FAHRENHEIT) + COFFICIENT_CONVERT_TEMPERATURE;
        public double ConvertFahrenheitToCelsius(double value) => (value - COFFICIENT_CONVERT_TO_CELSIUS) * COFFICIENT_CONVERT_TEMPERATURE;
    }
}
