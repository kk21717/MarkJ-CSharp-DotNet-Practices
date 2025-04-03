using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.NullCheck
{
    public class Tester
    {
        public static void TestExclamationMark()
        {
            Console.Write("please enter your age: ");
            string? strAge1 = Console.ReadLine();
            int numAge1 = int.Parse(strAge1);
            Console.WriteLine($"you are {numAge1} years old");

            Console.Write("please enter your age: ");
            string? strAge2 = Console.ReadLine();
            int numAge2 = int.Parse(strAge2!);
            Console.WriteLine($"you are {numAge2} years old");

            Console.Write("please enter your age: ");
            string? strAge3 = Console.ReadLine();
            int.TryParse(strAge3, out int numAge3);
            Console.WriteLine($"you are {numAge3} years old");

        }
    }
}
