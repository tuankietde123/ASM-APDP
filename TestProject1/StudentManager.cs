using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public StudentManager()
        {
        }

        internal void AddStudent(Student student)
        {
            students.Add(student);
        }

        internal IEnumerable<Student> GetStudents()
        {
            return students;
        }
    }
}
