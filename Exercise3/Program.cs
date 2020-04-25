using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1= @"The ""use"" of quotations causes difficulties";
            /**If we want to see quoted the word "use" in the console, we have to add
             * the two quotes (""use"") and the @ to say that its a statement. 
            **/
            string s2 = "The use of quotations causes difficulties";
            /** Here we don´t have to use the @ because nothing changes inside the statement.
            **/

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}
