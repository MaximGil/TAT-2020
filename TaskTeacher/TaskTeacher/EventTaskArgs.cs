using System;


namespace TaskTeacher
{
    class EventTaskArgs
    {
        public string TaskResult
        { get; }

        public EventTaskArgs(string taskResult)
        {
            this.TaskResult = taskResult;
        }
    }
}
