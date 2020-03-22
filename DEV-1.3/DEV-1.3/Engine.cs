
using System;

namespace DEV_1._3
{
    class Engine
    {
        int _power;
        double _capacity;
        string _typeEngine;
        string _serialNumber;
public double capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if(value > 0)
                {
                    _capacity = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public int power
        {
            get
            {
                return _power;
            }
            set
            {
                if (value > 0)
                {
                    _power = value;
                }
            }
        }
        public Engine(int power, double capacity, string typeEngine, string serialNumber)
        {
            _power = power;
            _capacity = capacity;
            _typeEngine = typeEngine;
            _serialNumber = serialNumber;
            ChechAvailableSymbols();

        }

        public virtual string GetInfo()
        {
            return $"Engine power: {_power}, Engine capacity: {_capacity}, Type engine: {_typeEngine} , Serial Number: {_serialNumber}";
        }
        private void ChechAvailableSymbols()
        {
            foreach (var chars in _typeEngine)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }
            foreach (var chars in _serialNumber)
            {
                if (!(Char.IsLetterOrDigit(chars)))
                {
                    throw new FormatException();
                }
            }

        }
    }



}
