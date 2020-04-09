
using DEV_2._1.Receiver;

namespace DEV_2._1.Commands
{
    class AverageTypePriceCommand : ICommand
    {
        Autopark autopark;

        public AverageTypePriceCommand(Autopark setAutopark) => autopark = setAutopark;

        public void Execute() => autopark.GetAveragePriсeTypes();

        public void Undo() => autopark.ExitApplication();
    }
}
