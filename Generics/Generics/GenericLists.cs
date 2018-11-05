using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generics<T> where T : IComparable
    {

        public bool Compare(T A ,T B) 
        {
            return A.Equals(B);
        }

    }
    class Person <THuman> where THuman : Human
    {
        public void SaySomething(THuman human)
        {
            Console.WriteLine("My name is {0}",human.Name);
        }
    }
    
}
