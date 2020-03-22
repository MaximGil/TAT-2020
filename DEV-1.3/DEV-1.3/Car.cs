using System;


namespace DEV_1._3
{
    class Car { 
    
        Engine engine;
        Transmission transmission;
        Chassis chassis;

        string _model;
        string _number;
        string _color;

        public Car(Engine engine, Transmission transmission, Chassis chassis, string model, string number, string color)
        {
           
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            _model = model;
            _number = number;
            this._color = color;
            CheckObjectsForNull();
        }

        public void GetCarInfo()
        {
            Console.WriteLine($"Information about car: Model: {_model}, Number: {_number}, Color: {_color}");
            Console.WriteLine($"information abour machine engine: {engine.GetInfo()}");
            Console.WriteLine($"information abour machine transmission: {transmission.GetInfo()}");
            Console.WriteLine($"information abour machine chassis: {chassis.GetInfo()}");
        }
        private void CheckObjectsForNull()
        {
            if (engine == null || transmission == null || chassis == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
