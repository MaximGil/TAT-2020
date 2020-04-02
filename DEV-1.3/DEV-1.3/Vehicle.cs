using System;

namespace DEV_1._3
{
  public abstract class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;

        protected Vehicle(Engine engine, Transmission transmission, Chassis chassis)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
        }

        public abstract string GetInfo();
     
    }
}
