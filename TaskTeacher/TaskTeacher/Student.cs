

using System;
using System.Text;

namespace TaskTeacher
{
    class Student : ITaskPerformer
    {

        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public delegate void StudentHandler(object sender, EventTaskArgs e);
        public event StudentHandler TeacherNotify;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string DoTask()
        {

            StringBuilder result = new StringBuilder();
            for (int i = 1; i < 15; i++)
            {
                char symbol = (char)Randomizer.rnd.Next(97, 123);
                result.Append(symbol);
            }
            TeacherNotify?.Invoke(this, new EventTaskArgs(result.ToString()));
            return result.ToString();

        }

    }
}
