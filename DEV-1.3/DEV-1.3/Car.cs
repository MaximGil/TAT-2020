using System;


namespace DEV_1._3
{
    class Car { 
    
        Engine engine;
        Transmission transmission;
        Chassis chassis;

        string _model;
        string _make;
        string _color;

        public Car(Engine engine, Transmission transmission, Chassis chassis, string model, string number, string color)
        {
           
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            _model = model;
            _make = number;
            this._color = color;
            CheckObjectsForNull();
            ChechAvailableSymbols();
        }

        public void GetCarInfo()
        {
            Console.WriteLine($"Information about car: Model: {_model}, Number: {_make}, Color: {_color}");
            Console.WriteLine($"information abour machine engine: {engine.GetInfo()}");
            Console.WriteLine($"information abour machine transmission: {transmission.GetInfo()}");
            Console.WriteLine($"information abour machine chassis: {chassis.GetInfo()}");
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
