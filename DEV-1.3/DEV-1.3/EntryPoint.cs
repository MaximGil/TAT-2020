

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var bus = new Bus("big bus", "96", 90);
            bus.GetInfo();
            var car = new Car(new Engine(400, 5.7, "biturbo", "ANV5642BC2"),
                      new Transmission("manual", 8, "Mercedes-Benz"), 
                      new Chassis(4, "BNF232353GH", 2345), "GTS", "NRF654F", "blue");

        }
    }
}
