using System;

namespace DEV_1._3
{
    public class CarPetrolFactory : IVehicleFactory
    {


        public Vehicle Create()
        {
            Engine engine = new Engine(typeEngine.Petrol, 1, 1, "A");
            Transmission transmission = new Transmission(typeOfTransmission.Auto, 6, "Ford");
            Chassis chassis = new Chassis(4, "a", 23);
            return new Car(engine, transmission, chassis, "Ford", "Focus", "green");
        }
    }
}