using System;

namespace DEV_1._3
{
    public class Chassis
    {
        int _numberOfWheels;
        string _numberChassis;
        int _permissibleLoad;
        public int NumberOfWheels
        {
            get => _numberOfWheels;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _numberOfWheels = value;
                }
            }
        }
        public int PermissibleLoad
        {
            get => _permissibleLoad;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _permissibleLoad = value;
                }
            }
        }

        public Chassis(int numberOfWheels, string numberChassis, int permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            _numberChassis = numberChassis;
            PermissibleLoad = permissibleLoad;
            ChechAvailableSymbols();
        }
        public virtual string GetInfo()
        {
            return $"Number of Wheels: {_numberOfWheels},  Number Of Classis {_numberChassis}, Permissible load {_permissibleLoad}";
        }

        private void ChechAvailableSymbols()
        {
            foreach (var chars in _numberChassis)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }

        }
    }

}
