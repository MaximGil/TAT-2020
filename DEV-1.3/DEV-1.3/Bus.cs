
using System;

namespace DEV_1._3
{
    class Bus
    {
        Engine engine ;
        Transmission transmission;
        Chassis chassis; 

        string _type;
        string _numberOfBus;
        int _maxSpeed;


        public Bus(Engine engine, Transmission transmission, Chassis chassis, string type, string numberOfBus, int maxSpeed)
        {
           
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            _type = type;
            _numberOfBus = numberOfBus;
            _maxSpeed = maxSpeed; 
            CheckObjectsForNull();
            ChechAvailableSymbols();

        }

        public  void GetBusInfo()
        {
            Console.WriteLine($"Information about bus:Type of bus: {_type}, Number of bus: {_numberOfBus}, Maximal speed: {_maxSpeed} ");
            Console.WriteLine($"Information about engine bus: {engine.GetInfo()}");
            Console.WriteLine($"Information about transmission bus: {transmission.GetInfo()}");
            Console.WriteLine($"Information about chassis bus: {chassis.GetInfo()}");
        }

        private void CheckObjectsForNull()
        {
            if (engine == null || transmission == null || chassis == null)
            {
                throw new ArgumentNullException();
            }
        }
        private void ChechAvailableSymbols()
        {
            foreach(var chars in _type)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }
            foreach(var chars in _numberOfBus)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }
            
        }
    }
}
