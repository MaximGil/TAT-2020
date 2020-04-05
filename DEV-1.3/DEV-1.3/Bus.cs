
using System;
using System.Text;

namespace DEV_1._3
{
   public class Bus : Vehicle
    {
        Engine _engine ;
        Transmission _transmission;
        Chassis _chassis; 

        int _numberOfSeats;
        string _numberOfBus;
        int _maxSpeed;

        public Bus(Engine engine, Transmission transmission, Chassis chassis, int NumberOfSeats, string numberOfBus, int maxSpeed) : base(engine, transmission, chassis)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
            _numberOfSeats = NumberOfSeats;
            _numberOfBus = numberOfBus;
            _maxSpeed = maxSpeed;
            CheckAvailableSymbolsInString();
 
        }
        private void CheckAvailableSymbolsInString()
        {
            foreach(var chars in _numberOfBus)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }
            
        }
        public override string GetInfo()
        {
            var informationAboutBus = new StringBuilder();
            informationAboutBus.AppendLine($"Information about bus:Type of bus: {_numberOfSeats}, Number of bus: {_numberOfBus}, Maximal speed: {_maxSpeed} ");
            informationAboutBus.AppendLine(base.GetInfo());
            return informationAboutBus.ToString();
        }
    }
}
