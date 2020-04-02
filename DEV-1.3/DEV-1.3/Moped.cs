using System;
using System.Text;

namespace DEV_1._3
{
    public class Moped : Vehicle
    {
        string _model;
        string _color;
        string _make;
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;

        public Moped(string model, string color, string make, Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
            _model = model;
            _color = color;
            _make = make;
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
            CheckAvailableSymbolsInString();
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

        public override string GetInfo()
        {
            var informationAboutMoped = new StringBuilder();
            informationAboutMoped.AppendLine($"Information about Truck: Model - {_model}, Make - {_make}, Color - {_color}");
            informationAboutMoped.AppendLine(base.GetInfo());
            return informationAboutMoped.ToString();
        }
    }

}
