using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Type the first number:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type the second number:");
            b = Convert.ToDouble(Console.ReadLine()); 
            
            Console.WriteLine("Type the third number:");
            c = Convert.ToDouble(Console.ReadLine());
            
            if(a*b*c>0)
            {
                Console.WriteLine("The product of this numbers will be a positive number");

            }
            else if(a*b*c == 0)
            {
                Console.WriteLine("The product of this numbers will be cero");
            }
            else
            {
                Console.WriteLine("The product of this numbers will be a negative number");
            }

        }
    }
}
