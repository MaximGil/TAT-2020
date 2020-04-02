

namespace DEV_1._3
{
    class CarManualFactory : IVehicleFactory
    {
        public Vehicle Create() => new Car(new Engine(typeEngine.Petrol, 1, 1, "A"),
                                           new Transmission(typeOfTransmission.Manual, 7, "Ford"),
                                           new Chassis(4, "ADAFA", 1230), "Audi", "A6", "green");
