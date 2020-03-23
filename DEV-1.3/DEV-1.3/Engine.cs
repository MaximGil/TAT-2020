
using System;

namespace DEV_1._3
{
    public class Engine
    {
        int _power;
        double _capacity;
        string _typeEngine;
        string _serialNumber;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public int Power
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
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public Engine(int power, double capacity, string typeEngine, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            _typeEngine = typeEngine;
            _serialNumber = serialNumber;
            ChechAvailableSymbols();
        }

        public virtual string GetInfo()
        {
            return $"Engine power: {Power}, Engine capacity: {Capacity}, Type engine: {_typeEngine} , Serial Number: {_serialNumber}";
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
