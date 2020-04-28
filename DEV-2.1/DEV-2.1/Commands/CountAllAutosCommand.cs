

using DEV_2._1.Receiver;

namespace DEV_2._1.Commands
{
    class CountAllAutosCommand : ICommand
    {
        Autopark autopark;

        public CountAllAutosCommand(Autopark setAutopark)
        {
            autopark = setAutopark;
        }

        public void Execute()
        {
            autopark.GetCountAllAutos();
        }

        public void Undo()
        {
            autopark.ExitApplication();
        }
    }
}

