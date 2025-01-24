using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private List<Student> students;
        public School() { 
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!students.Contains(student))
                return;

            students.Remove(student);
        }

        public int StudentsAtSchool() => students.Count;
        public int FemalStudentsAtSchool() => students.Where(s => s.Gender == Gender.female).Count();
        public int MaleStudentsAtSchool() => students.Where(s => s.Gender == Gender.male).Count();
        public int StudentsInClass(string className) => students.Where(s => s.ClassName == className).Count();
        

    }
}
