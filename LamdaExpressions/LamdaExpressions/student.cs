using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    class Student
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public string Name { get; set; }
        public List<Student> StudentList = new List<Student>();

        public void FindHighestGarde()
        {
           var students=StudentList.FindAll(stu => stu.Grade > 50);
           foreach(var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
        public void FinDStudentWithLetterM()
        {
            var students = StudentList.FindAll(stu => stu.Name.ToLower().StartsWith("m"));
            foreach(var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
