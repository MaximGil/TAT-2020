
using System;

namespace DEV_1._3
{
    class Transmission
    {
        string _typeOfTransmission;
        int _numberOfGears;
        string _manufacturer;

        public int numberOfGears
        {
            get
            {
                return _numberOfGears;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfGears = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public Transmission(string typeOfTransmission, int numberOfGears, string manufacturer)
        {
            _typeOfTransmission = typeOfTransmission;
            _numberOfGears = numberOfGears;
            _manufacturer = manufacturer;
            ChechAvailableSymbols();
        }
        public virtual string GetInfo()
        {
            return $"Type of transmission {_typeOfTransmission}, Number of gears: {_numberOfGears}, Manufacter: {_manufacturer}";
        }
        private void ChechAvailableSymbols()
        {
            foreach (var chars in _typeOfTransmission)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }
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
