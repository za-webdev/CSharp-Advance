using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MutliCastDelegate(List<Student> studentList);
    public delegate bool IsPassed(Student student);
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public List<Student> studentList = new List<Student>();


        public void  CkeckDuplictes(List<Student> studentList, IsPassed passed)
        {
            foreach (var student in studentList)
            {
                if (passed(student))
                {
                    Console.WriteLine("{0} has cleared",student.Name);
                }
            }
        }
        public void SaySomething(List<Student> studentList)
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.Name);
            } 
        }
        public void StudentId(List<Student> studentList)
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.Id);
            }
    }   }
}
