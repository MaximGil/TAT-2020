
using System;
using System.Collections.Generic;

namespace TaskTeacher
{
    class Teacher
    {
        public List<Student> Group;
        public List<string> dataStudents;

        public Teacher()
        {
            Group = new List<Student>();
            dataStudents = new List<string>(); 
        }
        /// <summary>
        /// add student in list 
        /// </summary>
        /// <param name="student"> object student</param>
        public void AddToGroup(Student student)
        {
            if (Group.Contains(student) == false)
            {
                Group.Add(student);
                student.TeacherNotify += acceptWork;
            }
        }
        /// <summary>
        /// get result taks which student is completed in dataStudents
        /// </summary>
        /// <param name="sender">event source</param>
        /// <param name="e">object which have data about object</param>
        public void acceptWork(object sender, EventTaskArgs e)
        {
           
            Student student = (Student)sender;
            dataStudents.Add(student.firstName + " " + student.lastName + " " + e.TaskResult);
            if(dataStudents.Count == Group.Count)
            PrintAllResult();
        }
      
        public void PrintAllResult()
        {
            foreach(var stud in dataStudents)
            Console.WriteLine(stud);
        }



    }
}
    