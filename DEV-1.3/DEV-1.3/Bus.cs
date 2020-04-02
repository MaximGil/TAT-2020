
using System;

namespace DEV_1._3
{
   public class Bus : Vehicle
    {
        Engine _engine ;
        Transmission _transmission;
        Chassis _chassis; 

        string _type;
        string _numberOfBus;
        int _maxSpeed;


        public Bus(Engine engine, Transmission transmission, Chassis chassis, string type, string numberOfBus, int maxSpeed) : base(engine, transmission, chassis)
        {
           
            this._engine = engine;
            this._transmission = transmission;
            this._chassis = chassis;
            _type = type;
            _numberOfBus = numberOfBus;
            _maxSpeed = maxSpeed; 
            CheckObjectsForNull();
            ChechAvailableSymbols();

        }

        public  void GetBusInfo()
        {
            Console.WriteLine($"Information about bus:Type of bus: {_type}, Number of bus: {_numberOfBus}, Maximal speed: {_maxSpeed} ");
            Console.WriteLine($"Information about engine bus: {_engine.GetInfo()}");
            Console.WriteLine($"Information about transmission bus: {_transmission.GetInfo()}");
            Console.WriteLine($"Information about chassis bus: {_chassis.GetInfo()}");
        }

        private void CheckObjectsForNull()
        {
            if (_engine == null || _transmission == null || _chassis == null)
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

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
