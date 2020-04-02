

namespace DEV_1._3
{
    class BusFactory :IVehicleFactory
    {
        public Vehicle Create() => new Bus(new Engine(typeEngine.Petrol, 1, 1, "A"),
                                           new Transmission(typeOfTransmission.Manual, 7, "Ford"),
                                           new Chassis(4, "ADAFA", 1230),45, "1234123", 120 );
    }
}
