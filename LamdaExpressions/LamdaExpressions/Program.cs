using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.StudentList.Add(new Student() { Id = 1, Name = "hina", Grade = 20 });
            student.StudentList.Add(new Student() { Id = 2, Name = "zoya", Grade = 51 });
            student.StudentList.Add(new Student() { Id = 3, Name = "mona", Grade = 67 });
            student.StudentList.Add(new Student() { Id = 3, Name = "Maria", Grade = 67 });  
            student.StudentList.Add(new Student() { Id = 4, Name = "lola", Grade = 12 });

            Console.WriteLine("student with highest grade");
            student.FindHighestGarde();

            Console.WriteLine("student with letter M");
            student.FinDStudentWithLetterM();
        }
    }
}
