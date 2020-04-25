using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //We declare the integer

            Console.WriteLine("Write an integer between 0 and 255: "); //Here we ask in the console for an integer under 8 bits of large
                                                                        //It could be done for more of 8-bit of large but it can introduce bit errors
            n = Convert.ToInt32(Console.ReadLine());

            string binary_N = Convert.ToString(n, 2);

            Console.WriteLine("The number you introduced is: " + n);
            Console.WriteLine("The number you introduced in binary is:" + binary_N);

            int p;//We declare the integer of the position

           

            Console.WriteLine("Write the position: "); //Here we ask in the console for an integer for the number of bits

            p = Convert.ToInt32(Console.ReadLine());

            int i = 1; // 00000001
            int mask = i << p; // Move the 1-st bit left by p positions
                               // If i & mask are positive then the p-th bit of n is 1

            Console.WriteLine("The number in the position " + p + " is a:");
            Console.WriteLine((n & mask) != 0 ? 1 : 0);




        }
    }
}
