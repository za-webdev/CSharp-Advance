using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                int a = 4;
                int b = 0;
                var c = a /b;
                Console.WriteLine(c);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }
            catch (Exception ex)
            {

                Console.WriteLine("error");
            }
        }
    }
}
