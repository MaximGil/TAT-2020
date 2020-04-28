using DEV_2._1.Receiver;

namespace DEV_2._1.Commands
{
    class AverigePriseCommand : ICommand
    {
        Autopark autopark;

        public AverigePriseCommand(Autopark setAutopark) => autopark = setAutopark;

        public void Execute() => autopark.GetAveragePrice();

        public void Undo() => autopark.ExitApplication();
    }
}
