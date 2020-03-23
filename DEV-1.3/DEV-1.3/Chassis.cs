using System;

namespace DEV_1._3
{
    public class Chassis
    {
        int _numberOfWheels;
        string _numberChassis;
        int _permissibleLoad;
        public int numberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfWheels = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public int permissibleLoad
        {
            get
            {
                return _permissibleLoad;
            }
            set
            {
                if (value > 0)
                {
                    _permissibleLoad = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public Chassis(int numberOfWheels, string numberChassis, int permissibleLoad)
        {
            numberOfWheels = numberOfWheels;
            _numberChassis = numberChassis;
            permissibleLoad = permissibleLoad;
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
