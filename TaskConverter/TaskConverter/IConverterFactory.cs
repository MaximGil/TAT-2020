

namespace TaskConverter
{
    interface IConverterFactory
    {
        IConverter СreateConverterTemperature();
        IConverter СreateConverterLength();
    }
}
