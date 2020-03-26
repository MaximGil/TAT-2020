
using System.Collections.Generic;

namespace TaskTeacher
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < 10;i++)
            {
                students.Add(new Student("firstName" + i.ToString(), "lastName" + i.ToString()));
            }
            
            Teacher teacher = new Teacher();
            foreach(var stud in students)
            {
                teacher.AddToGroup(stud);
            }

                
            foreach (var stud in students)
            {
                stud.DoTask();
            }
        }


    }
}
