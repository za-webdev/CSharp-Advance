using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
   public class ClassRoom
    {
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student() {Id = 1, Name ="Kevin", Grade = 50 },
                new Student() {Id = 2, Name ="lola", Grade = 15 },
                new Student() {Id = 5, Name ="hina" },
                new Student() {Id = 4, Name ="mark", Grade = 20 },
                new Student() {Id = 3, Name ="maria",Grade = 30 },


            };
        }
    }
}
