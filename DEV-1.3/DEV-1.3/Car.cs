using System;
using System.Text;

namespace DEV_1._3
{
    public class Car : Vehicle
    {

        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;

        string _model;
        string _make;
        string _color;
 
        public Car(Engine engine, Transmission transmission, Chassis chassis, string model, string make, string color) : base(engine, transmission, chassis)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
            _model = model;
            _make = make;
            _color = color;
            CheckAvailableSymbols();
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
            informationAboutCar.AppendLine(base.GetInfo());
            return informationAboutCar.ToString();
        }
    }
}
