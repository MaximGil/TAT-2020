

using DEV_2._1.Commands;
using DEV_2._1.Invoker;
using DEV_2._1.Receiver;
using System;

namespace DEV_2._1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Autopark autopark = Autopark.GetInstance();
                Manager managerVasya = new Manager();
                managerVasya.SetCommand(new CountTypesCommand(autopark));
                managerVasya.SetCommand(new CountAllAutosCommand(autopark));
                managerVasya.SetCommand(new AverigePriseCommand(autopark));
                managerVasya.SetCommand(new AverageTypePriceCommand(autopark));
                managerVasya.GetInfo();
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
