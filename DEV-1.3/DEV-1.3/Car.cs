using System;
using System.Text;

namespace DEV_1._3
{
    public class Car : Vehicle
    {

        Engine engine;
        Transmission transmission;
        Chassis chassis;

        string _model;
        string _make;
        string _color;

        public Car(Engine engine, Transmission transmission, Chassis chassis, string model, string make, string color) : base(engine, transmission, chassis)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            _model = model;
            _make = make;
            _color = color;
            CheckAvailableSymbols();
            CheckObjectsForNull();
        }

        public void GetCarInfo()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        private void CheckObjectsForNull()
        {
            if (engine == null || transmission == null || chassis == null)
            {
                throw new ArgumentNullException();
            }
        }
        private void CheckAvailableSymbols()
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

        public override string GetInfo()
        {
            var informationAboutCar = new StringBuilder();
            informationAboutCar.AppendLine($"Information about car: Model: {_model}, Number: {_make}, Color: {_color}");
            informationAboutCar.AppendLine($"information abour machine engine: {engine.GetInfo()}");
            informationAboutCar.AppendLine($"information abour machine transmission: {transmission.GetInfo()}");
            informationAboutCar.AppendLine($"information abour machine chassis: {chassis.GetInfo()}");
            return informationAboutCar.ToString() ;
        }
    }
}
