

namespace DEV_1._3
{
    class TruckManualTransmissionFactory : IVehicleFactory
    {

        public Vehicle Create() => new Truck(new Engine(typeEngine.Petrol, 1, 1, "A"),
                                           new Transmission(typeOfTransmission.Manual, 7, "DAF"),
                                           new Chassis(4, "ADAFA", 1230), "DAF", " 150", "green");
    }
}
