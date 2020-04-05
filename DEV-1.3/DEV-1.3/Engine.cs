
using System;

namespace DEV_1._3
{
   public enum typeEngine
    {
        Petrol, Diesel, Electric, Hybrid
    };
    public class Engine
    {
        public typeEngine typeEngine { get; private set; }
        int _power;
        double _capacity;
    
        string _serialNumber;
        public double Capacity
        {
            get => _capacity;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _capacity = value;
                }
            }
        }
        public int Power
        {
            get => _power;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _power = value;
                }
            }
        }

        public Engine(typeEngine typeEngine, int power, double capacity, string serialNumber)
        {
            this.typeEngine = typeEngine;
            Power = power;
            Capacity = capacity;
            _serialNumber = serialNumber;
        }

        public virtual string GetInfo()
        {
            return $"Engine power: {Power}, Engine capacity: {Capacity}, Type engine: {typeEngine} , Serial Number: {_serialNumber}";
        }
        private void ChechAvailableSymbols()
        {
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
