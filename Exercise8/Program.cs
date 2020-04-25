using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduce four digits: ");
            num = Convert.ToInt32(Console.ReadLine());

            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            Console.WriteLine("This is the number that you introduced: " + d + c + b + a);


            int sum = a + b + c + d;
            Console.WriteLine("This is the sum of the four digits: " + sum);

            Console.WriteLine("This is the number in reverse order: " +a + b + c + d);

            Console.WriteLine("This is the number with the last digit in first position:" +a +d +c +b);

            Console.WriteLine("This is the exchange between the second and the third digit: " +d +b +c +a);
        }
    }
}
