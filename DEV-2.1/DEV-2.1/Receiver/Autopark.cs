using System;
using System.Xml.Linq;

namespace DEV_2._1.Receiver
{
    class Autopark
    {
        private static Autopark _instance;
        private XDocument _xAutopark;
        public const string PATH = @"f://C#/TAT-2020/DEV-2.1/DEV-2.1/Autopark.xml";

        private Autopark()
        {
            _xAutopark = XDocument.Load(PATH);
        }

        public static Autopark GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Autopark();
            }
            return _instance;
        }

        public void GetCountAllAutos()
        {
            var totalCountAutos = 0;
            foreach (XElement element in _xAutopark.Root.Elements())
            {
                totalCountAutos += (int)element.Element("count");
            }
            Console.WriteLine($"total number of cars:{totalCountAutos}");
        }
        public void GetTypesCommand()
        {
            var totalTypesAutos = 1;
            XElement previuosElement = _xAutopark.Root.Element("Autos");
            foreach (XElement element in _xAutopark.Root.Elements())
            {
                if (previuosElement.Attribute("name").Value != element.Attribute("name").Value)
                {
                    totalTypesAutos++;
                }
                previuosElement = element;
            }
            Console.WriteLine($"total number of cars:{totalTypesAutos}");
        }

        public void GetAveragePrice()
        {
            var averagePrice = 0.0;
            var totalSum = 0.0;
            var countAutos = 0;
            foreach (XElement element in _xAutopark.Root.Elements())
            {
                totalSum += (double)element.Element("cost");
                countAutos++;
            }
            averagePrice = totalSum / countAutos;
            Console.WriteLine($"average price is: {averagePrice}");
        }
        public void GetAveragePriсeTypes()
        {
            var totalSum = 0.0;
            var averageTypePrice = 0.0;
            var countAutos = 0;
            var inputName = Console.ReadLine();

            foreach (XElement element in _xAutopark.Root.Elements())
            {
                if (element.Attribute("name").Value == inputName)
                {
                    totalSum += (double)element.Element("cost");
                    countAutos++;
                }
                else throw new ArgumentNullException();
            }
            averageTypePrice = totalSum / countAutos;
            Console.WriteLine($"average type price is: {averageTypePrice}");
        }
        public void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
