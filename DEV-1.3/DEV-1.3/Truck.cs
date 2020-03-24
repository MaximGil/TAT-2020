using System;


namespace DEV_1._3
{
  public class Truck
    {
        Engine engine;
        Transmission transmission;
        Chassis chassis;
        string _model;
        string _color;
        string _make; // марка грузовика 

        public Truck(Engine engine, Transmission transmission, Chassis chassis, string model, string color, string make)
        {
           
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            _model = model;
            _color = color;
            _make = make;
            CheckObjectsForNull();
            ChechAvailableSymbols();
        }

        public void GetTruckInfo()
        {
            Console.WriteLine($"Information about Truck: Model - {_model}, Make - {_make}, Color - {_color}");
            Console.WriteLine($"Information about engine truck: {engine.GetInfo()}");
            Console.WriteLine($"Information about transmission truck: {transmission.GetInfo()}");
            Console.WriteLine($"Information about chassis truck: {chassis.GetInfo()}");
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
