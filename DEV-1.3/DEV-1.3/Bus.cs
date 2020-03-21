
using System;

namespace DEV_1._3
{
    class Bus
    {
        Engine engine = new Engine(200, 4.0, "petrol", "128BN234A");
        Transmission transmission =  new Transmission("automatic", 6, "Ford");
        Chassis chassis = new Chassis(6, "B768CD0", 2760);

        string _type;
        string _numberOfBus;
        int _maxSpeed;

        public Bus(string type, string numberOfBus, int maxSpeed)
        {
            _type = type;
            _numberOfBus = numberOfBus;
            _maxSpeed = maxSpeed;
        }

        public  void GetInfo()
        {
            Console.WriteLine($"Information about bus:Type of bus: {_type}, Number of bus: {_numberOfBus}, Maximal speed: {_maxSpeed} ");
            Console.WriteLine($"Information about engine bus: {engine.GetInfo()}");
            Console.WriteLine($"Information about transmission bus: {transmission.GetInfo()}");
            Console.WriteLine($"Information about chassis bus: {chassis.GetInfo()} ");


        }
    }
}
