

using System;

namespace DEV_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var baseSystem = int.Parse(Console.ReadLine());
            var con = new Conventor(inputString, baseSystem);
            System.Console.WriteLine(con.ConvertToAnotherSystem());

        }
    }
}
