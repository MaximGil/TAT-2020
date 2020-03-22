using System;


namespace DEV_1._3
{
    class Moped
    {   string _model;
        string _color;
        string _make; 
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        


        public Moped(Engine engine, Transmission transmission, Chassis chassis, string model, string color, string make)
        {
           
            this._engine = engine;
            this._transmission = transmission;
            this._chassis = chassis;
            _model = model;
            _color = color;
            _make = make;
            CheckObjectsForNull();
            ChechAvailableSymbols();
        }

        public void GetTruckInfo()
        {
            Console.WriteLine($"Information about Truck: Model - {_model}, Make - {_make}, Color - {_color}");
            Console.WriteLine($"Information about engine truck: {_engine.GetInfo()}");
            Console.WriteLine($"Information about transmission truck: {_transmission.GetInfo()}");
            Console.WriteLine($"Information about chassis truck: {_chassis.GetInfo()}");
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
            foreach (var chars in _model)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }
            foreach (var chars in _make)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }

        }
    }

}
