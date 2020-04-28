using System.Collections.Generic;

namespace DEV_2._1.Invoker
{
    class Manager 
    {
     
        List<ICommand> commands;

        public Manager() 
        {
            commands = new List<ICommand>(); 
        }
        public void SetCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void GetInfo()
        {
           foreach(var command in commands)
            {
                command.Execute();
            }
        }

        public void UndoGetInfo()
        {
            foreach(var command in commands)
            {
                command.Execute();
            }
        }
    }
}
