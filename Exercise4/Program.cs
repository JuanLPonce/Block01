using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; //We declare the integer

            Console.WriteLine("Write an integer: "); //Here we ask in the console for an integer

            a = Convert.ToInt32(Console.ReadLine());

            if(a%2==0)  //With if, the conditional will return "Its even" if the remainder of the division is 0; if not, it will return "Its odd"
            {
                Console.WriteLine("Its even");

            }
            else
            {
                Console.WriteLine("Its odd");
            }

        }
    }
}
