using System;
using System.Text;

namespace DEV_1._3
{
    public abstract class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        public Engine Engine
        {
            get => _engine;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _engine = value;
                }
            }
        }
        public Transmission Transmission
        {
            get => _transmission;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _transmission = value;
                }

            }
        }
        public Chassis Chassis
        {
            get => _chassis;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _chassis = value;
                }
            }
        }

        protected Vehicle(Engine engine, Transmission transmission, Chassis chassis)
        {
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
        }

        public virtual string GetInfo()
        {
            var informationAboutVehicle = new StringBuilder();
            informationAboutVehicle.AppendLine($"information abour machine engine: {_engine.GetInfo()}");
            informationAboutVehicle.AppendLine($"information abour machine transmission: {_transmission.GetInfo()}");
            informationAboutVehicle.AppendLine($"information abour machine chassis: {_chassis.GetInfo()}");
            return informationAboutVehicle.ToString();        
        }
    }
}
