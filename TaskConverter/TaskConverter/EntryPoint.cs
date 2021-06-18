using System;
namespace TaskConverter
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IConverterFactory factory = new ConverterFactory();
            IConverter converter;
            double value = Convert.ToDouble(args[0]);
            string direction = args[1];

            //if (direction == "CF" || direction == "FC")
            //{
            //    converter = factory.СreateConverterTemperature();
            //    Console.WriteLine( converter.Convert(value, args[1]));

            //}
            //else if (direction == "MF" || direction == "FM")
            //{
            //    converter = factory.СreateConverterLength();
            //    Console.WriteLine(converter.Convert(value, args[1]));
            //}
            //else
            //{
            //    throw new ArgumentException();
            //}

            for (int i = 1; i < args.Length; i+=2)
            {
                if (args[i] == "CF" || args[i] == "FC")
                {
                    converter = factory.СreateConverterTemperature();
                    Console.WriteLine(converter.Convert(Convert.ToDouble(args[i-1]), args[i]));

                }
                else if (args[i] == "MF" || args[i] == "FM")
                {
                    converter = factory.СreateConverterLength();
                    Console.WriteLine(converter.Convert(Convert.ToDouble(args[i-1]), args[i]));
                }
                else
                {
                    throw new ArgumentException();
                }

            }
        }
    }
}

