using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            human.Name = "zoya";
            var person = new Person<Human>();
            person.SaySomething(human);
            var generics = new Generics<int>();
            if (generics.Compare(2, 2)){
                Console.WriteLine("are equal");
            }
            else
                Console.WriteLine(" are not equal");
                Console.ReadKey();

        }
    }
}
