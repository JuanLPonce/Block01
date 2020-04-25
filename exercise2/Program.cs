using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            float  a, b, c, d, e, f;
            double g, h, i, j, k, l;
            decimal m, n, o, p, q, r;

            //These are the float variables
            a = 5f;
            b = -5.01f;
            c = 34.567839023f;
            d = 12.345f;
            e = 8923.1234857f;
            f = 3456.091124875956542151256683467f; 

            //These are the double variables
            g = 5d;
            h = -5.01d;
            i = 34.567839023d;
            j = 12.345d;
            k = 8923.1234857d;
            l = 3456.091124875956542151256683467d;

            //These ones are the decimal variables
            m = 5m;
            n = -5.01m;
            o = 34.567839023m;
            p = 12.345m;
            q = 8923.1234857m;
            r = 3456.091124875956542151256683467m;

            Console.WriteLine("First float variable = " + a);  
            Console.WriteLine("Second float variable = " + b);
            Console.WriteLine("Third float variable = " + c);
            Console.WriteLine("Fourth float variable = " + d);
            Console.WriteLine("Fifth float variable = " + e);
            Console.WriteLine("Sixth float variable = " + f);
            /**For the float variables, after debugging, we see that the they can hold a maximum
             * of seven numbers for each variable. The rest of the significant numbers are excluded.
            So, we can represent numbers 5, -5.01 and 12.345 with this variable. **/
            Console.WriteLine("");


            Console.WriteLine("First double variable = " + g);
            Console.WriteLine("Second double variable = " + h);
            Console.WriteLine("Third double variable = " + i);
            Console.WriteLine("Fourth double variable = " + j);
            Console.WriteLine("Fifth double variable = " + k);
            Console.WriteLine("Sixth double variable = " + l);
            /**For the double variables, we see that the maximum of significant numbers is fifteen, so,
             * we can represent all the numbers except one, 3456.091124875956542151256683467, because it
             * exceeds the maximum of significant numbers.
            **/
            Console.WriteLine("");

            Console.WriteLine("First decimal variable = " + m);
            Console.WriteLine("Second decimal variable = " + n);
            Console.WriteLine("Third decimal variable = " + o);
            Console.WriteLine("Fourth decimal variable = " + p);
            Console.WriteLine("Fifth decimal variable = " + q);
            Console.WriteLine("Sixth decimal variable = " + r);
            /**For the decimal variables, the maximum is 29, so we can represent all of the numbers except
             * the last one, 3456.091124875956542151256683467. It will round up in the end, in ...3467 to ...35
            **/
        }
    }
}
