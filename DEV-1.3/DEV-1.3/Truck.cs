using System;
using System.Text;

namespace DEV_1._3
{
    public class Truck : Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        string _model;
        string _color;
        string _make; // make = марка 

        public Truck(Engine engine, Transmission transmission, Chassis chassis, string model, string color, string make) : base(engine, transmission, chassis)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
            _model = model;
            _color = color;
            _make = make;
            CheckAvailableSymbolsInString();
        }

        public override string GetInfo()
        {
            var informationAboutTruck = new StringBuilder();
            informationAboutTruck.AppendLine($"Information about Truck: Model - {_model}, Make - {_make}, Color - {_color}");
            informationAboutTruck.AppendLine(base.GetInfo());
            return informationAboutTruck.ToString();
        }

        private void CheckAvailableSymbolsInString()
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
