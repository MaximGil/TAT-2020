

namespace TaskConverter
{
    class ConverterFactory : IConverterFactory
    {
        public IConverter СreateConverterLength()
        {
            return new LengthConverter();

        }

        public IConverter СreateConverterTemperature()
        {
            return new TemperatureConverter();
        }
    }
}
