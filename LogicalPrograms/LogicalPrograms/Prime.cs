using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Prime
    {
        public static void Pro()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt16(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine($"{n} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{n} is Not a Prime Number");
            }
        }
    }
}
