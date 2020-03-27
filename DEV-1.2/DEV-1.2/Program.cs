

using System;

namespace DEV_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = args[0];
            var baseSystem = int.Parse(Console.ReadLine());
            var converter = new Converter(inputString.ToString(), baseSystem);
            Console.WriteLine(converter.ConvertToAnotherSystem());

        }
    }
}
