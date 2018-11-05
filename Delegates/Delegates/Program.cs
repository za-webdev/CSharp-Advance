using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            
            student.studentList.Add(new Student() { Id = 1, Name = "hina", Grade=20 });
            student.studentList.Add(new Student() { Id = 2, Name = "zoya", Grade = 50 });
            student.studentList.Add(new Student() { Id = 3, Name = "mona", Grade = 67 });
            student.studentList.Add(new Student() { Id = 4, Name = "lola", Grade = 12 });
            
            MutliCastDelegate del;
            del = new MutliCastDelegate(student.SaySomething);
            del += student.StudentId;
            del(student.studentList);

            var isPassed = new IsPassed(Passed);
            student.CkeckDuplictes(student.studentList,isPassed);
            Console.ReadLine();
        }

        public static bool Passed(Student student)
        {
            if (student.Grade > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
