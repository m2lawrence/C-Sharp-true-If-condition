using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIfComTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            int Val1 = 1;
            int Val2 = 0;

            System.Console.WriteLine("Getting ready to do the If Statement...");

            if (Val1 != Val2) //not equals to.
            {
                System.Console.WriteLine("If condition was true.");
            }
            System.Console.WriteLine("Done with the If Statement Mike.");
            System.Console.ReadKey(); //pauses the programme until anykey is pressed.
        }
    }
}
// Here the condition is true, because Val1 is not equal to Val2. 