using DEV_2._1.Receiver;

namespace DEV_2._1.Commands
{
    class CountTypesCommand : ICommand
    {
        Autopark autopark;

        public CountTypesCommand(Autopark setAutopark)
        {
            autopark = setAutopark;
        }

        public void Execute()
        {
            autopark.GetTypesCommand();
        }

        public void Undo()
        {
            autopark.ExitApplication();
        }
    }
}
