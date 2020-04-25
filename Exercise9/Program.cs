using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int aux;
            
            
            Console.WriteLine("Put the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Put the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("a value is : " +a);
            Console.WriteLine("b value is : " +b);

            if (a>b)
            {
                aux = a;

                a = b;

                b = aux;

                Console.WriteLine("a value is greater than b, so we exchange their values");

                Console.WriteLine("Now the value of a is: " + a);
                Console.WriteLine("Now the value of b is: " + b);
            }
            else
            {
                Console.WriteLine("The values remain the same because b is equal or greater than a");
            }



        }
    }
}
