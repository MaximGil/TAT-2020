

using System;
using System.Collections.Generic;

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                //var carEngine = new Engine(typeEngine.Petrol, 200, 3.7, "adasfadzga");
                //var carTransmission = new Transmission(typeOfTransmission.Mechanical, 6, "Ford");
                //var carChassis = new Chassis(2, "123qe131", 1231241);
                //var car = new Car(carEngine, carTransmission, carChassis, "23asdsgasda", "adafasda", "adafasdasfa");
                //Console.WriteLine(car.GetInfo());

                List<Vehicle> vehicles = new List<Vehicle>();
                var petrolCar = new CarPetrolFactory();
<<<<<<< HEAD
                var carManualFactory = new CarManualFactory();
                var truckManualTransmissionFactory = new TruckManualTransmissionFactory();
                var busFactory = new BusFactory();
                vehicles.Add(petrolCar.Create());
                vehicles.Add(petrolCar.Create());
                vehicles.Add(carManualFactory.Create());
                vehicles.Add(carManualFactory.Create());
                vehicles.Add(carManualFactory.Create());
                vehicles.Add(busFactory.Create());
                vehicles.Add(busFactory.Create());
                vehicles.Add(truckManualTransmissionFactory.Create());
                vehicles.Add(truckManualTransmissionFactory.Create());
=======
                Vehicle vehicle = petrolCar.Create();
                Console.WriteLine(vehicle.GetInfo());
>>>>>>> a1d238b5053a2e39b52834450d5bcb3fb4bcb1e8


            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
