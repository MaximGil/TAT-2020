
namespace DEV_1._3
{
    class Engine
    {
        int _power;
        double _capacity;
        string _typeEngine;
        string _serialNumber;

        public Engine(int power, double capacity, string typeEngine, string serialNumber)
        {
            _power = power;
            _capacity = capacity;
            _typeEngine = typeEngine;
            _serialNumber = serialNumber;

        }

        public virtual string GetInfo()
        {
            return $"Engine power: {_power}, Engine capacity: {_capacity}, Type engine: {_typeEngine} , Serial Number: {_serialNumber}";
        }

    }



}
