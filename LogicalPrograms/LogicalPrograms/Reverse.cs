using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Reverse
    {
        public static void Pro()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt16(Console.ReadLine());
            int rem = 0, rev = 0;
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine($"The reverse is {rev}");
        }
    }
}
