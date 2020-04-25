using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            double SUM;
           
            

            Console.WriteLine("Write five integers and I will do the sum: ");

            a = Convert.ToDouble(Console.ReadLine());
            
            if (a % 2 == 0 || a % 2 == 1)
            {
                
            }
            else
            {
                Console.WriteLine("You didn't introduced an integer, please try again: ");
                a = Convert.ToDouble(Console.ReadLine());
            }

            b = Convert.ToDouble(Console.ReadLine());
            
            if (b % 2 == 0 || b % 2 == 1)
            {
               
            }
            else
            {
                Console.WriteLine("You didn't introduced an integer, please try again: ");
                b = Convert.ToDouble(Console.ReadLine());
            }

            c = Convert.ToDouble(Console.ReadLine());

            if (c % 2 == 0 || c % 2 == 1)
            {
                
            }
            else
            {
                Console.WriteLine("You didn't introduced an integer, please try again: ");
                c = Convert.ToDouble(Console.ReadLine());
            }

            d = Convert.ToDouble(Console.ReadLine());

            if (d % 2 == 0 || d % 2 == 1)
            {
                
            }
            else
            {
                Console.WriteLine("You didn't introduced an integer, please try again: ");
                d = Convert.ToDouble(Console.ReadLine());
            }

            e = Convert.ToDouble(Console.ReadLine());
            
            if (e % 2 == 0 || e % 2 == 1)
            {
               
            }
            else
            {
                Console.WriteLine("You didn't introduced an integer, please try again: ");
                e = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("These are the numbers you have chosen: ");
            Console.WriteLine("First number : " + a);
            Console.WriteLine("Second number : " + b);
            Console.WriteLine("Third number : " + c);
            Console.WriteLine("Fourth number : " + d);
            Console.WriteLine("Fifth number : " + e);

            SUM = a + b + c + d + e;

            Console.WriteLine("The sum is: " + SUM);
        } 
    } 
}
