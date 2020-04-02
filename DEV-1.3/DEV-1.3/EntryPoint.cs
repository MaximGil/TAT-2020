

using System;

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                var carEngine = new Engine(typeEngine.Petrol, 200, 3.7, "adasfadzga");
                var carTransmission = new Transmission(typeOfTransmission.Mechanical, 6, "Ford");
                var carChassis = new Chassis(2, "123qe131", 1231241);
                //var carEngine = new Engine(400, 5.7, "biturbo", "ANV5642BC2");
                //var carTransmission = new Transmission(E, 8, "MercedesBenz");
                //var carChassis = new Chassis(4, "BNF232353GH", 2345);
                //var bus = new Bus(new Engine(-200, 4.0, "Petrol", "12BNLAD23"),
                //                  new Transmission("automatic", 6, "Ford"),
                //                  new Chassis(6, "B768CD0", 2760),
                //                  "Doubledecker", "96", 90);
                //bus.GetBusInfo();
                //var car = new Car(carEngine, carTransmission, carChassis, "GTS", "NRF654F", "blue");
                //car.GetCarInfo();
                //var truck = new Truck(new Engine(500, 8.7, "diesel", "NHFAR234DAD"),
                //                      new Transmission("Manual", 12, "DAF"),
                //                      new Chassis(8, "NGD5412BND", 20000),
                //                      "LF", "White", "DAF");
                //truck.GetTruckInfo();
                var car = new Car(carEngine, carTransmission, carChassis, "23asdsgasda", "adafasda", "adafasdasfa");
                Console.WriteLine(car.GetInfo());
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
