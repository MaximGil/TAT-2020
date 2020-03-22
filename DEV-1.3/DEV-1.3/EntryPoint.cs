

using System;

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                var carEngine = new Engine(400, 5.7, "biturbo", "ANV5642BC2");
                var carTransmission = new Transmission("manual", 8, "Mercedes-Benz");
                var carChassis = new Chassis(4, "BNF232353GH", 2345);
                var bus = new Bus(new Engine(200, 4.0, "Petrol", "12BNLAD23"),
                                  new Transmission("automatic", 6, "Ford"),
                                  new Chassis(6, "B768CD0", 2760),
                                  "Double-decker", "96", 90);
                bus.GetBusInfo();
                var car = new Car(carEngine, carTransmission, carChassis, "GTS", "NRF654F", "blue");
                car.GetCarInfo();
                var truck = new Truck(new Engine(500, 8.7, "diesel", "NHFAR234DAD"),
                                      new Transmission("Manual", 12, "DAF"),
                                      new Chassis(8, "NGD5412BND", 20000),
                                      "LF", "White", "DAF");
                truck.GetTruckInfo();
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
