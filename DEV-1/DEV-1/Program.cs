using System;


namespace DEV_1
{
    class Program
    {/// <summary>
     /// Input string and get results
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var sequenceLenght = new SequenceLength(inputString);
            sequenceLenght.SequenceGetCounter();
            Console.WriteLine(sequenceLenght.ToString());

        }

       
    }
}
