

using System;
using System.Text;

namespace TaskTeacher
{
    class Student : ITaskPerformer
    {
        readonly int resultLength = 15;
        readonly int minLetterCount = 97;
        readonly int maxLetterCount = 123;
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public delegate void StudentHandler(object sender, EventTaskArgs e);
        public event StudentHandler TeacherNotify;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        /// <summary>
        /// get string with random letters and give notify
        /// </summary>
        /// <returns>string with symbols</returns>
        public string DoTask()
        {

            StringBuilder result = new StringBuilder();
            for (int i = 1; i < resultLength; i++)
            {
                char symbol = (char)Randomizer.rnd.Next(minLetterCount, maxLetterCount);
                result.Append(symbol);
            }
            TeacherNotify?.Invoke(this, new EventTaskArgs(result.ToString()));
            return result.ToString();

        }

    }
}
