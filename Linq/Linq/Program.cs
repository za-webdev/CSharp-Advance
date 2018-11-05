using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom().GetStudents();
            var students = classRoom
                                    .Where(stu => stu.Name.ToLower().StartsWith("m"))
                                    .OrderBy(stu => stu.Id);

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }

            var individualStudent = classRoom.SingleOrDefault(stu => stu.Name == "hjhjhj");
            if(individualStudent == null)
            {
                Console.WriteLine("not available");
            }
            else
            {

                Console.WriteLine(individualStudent.Id);
            }

            var firstStudentWithGoodGrade = classRoom.First(stu => stu.Grade >= 50);
            Console.WriteLine(firstStudentWithGoodGrade.Name);


            var minGarde = classRoom.Min(stu => stu.Grade);
            Console.WriteLine(minGarde);


           
           foreach(var studentGarde in classRoom)
            {
                Console.WriteLine(studentGarde.Name +" "+studentGarde.Grade );
            }
        }
    }
}
