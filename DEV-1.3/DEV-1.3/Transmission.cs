
using System;

namespace DEV_1._3
{
    public enum typeOfTransmission
    {
        Mechanical,
        Electrical,
        Hydrovolume,
        Combined
    };
    public class Transmission
    {

        public typeOfTransmission typeOfTransmission { get; }
        int _numberOfGears;
        string _manufacturer;

        public int numberOfGears
        {
            get => _numberOfGears;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _numberOfGears = value;
                }
            }
        }

        public Transmission(typeOfTransmission typeOfTransmission, int numberOfGears, string manufacturer)
        {
            this.typeOfTransmission = typeOfTransmission;
            _numberOfGears = numberOfGears;
            _manufacturer = manufacturer;
            CheckAvailableSymbolsContainsString();
        }

        public virtual string GetInfo()
        {
            return $"Type of transmission {typeOfTransmission}, Number of gears: {_numberOfGears}, Manufacter: {_manufacturer}";
        }
        private void CheckAvailableSymbolsContainsString()
        {
            foreach (var chars in _manufacturer)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }

        }
    }
}
