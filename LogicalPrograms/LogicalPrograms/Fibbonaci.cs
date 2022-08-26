using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibbonaci
    {
        public static void Pro()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int t1 = 0, t2 = 1, t3 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(t1);
                }
                if (i == 1)
                {
                    Console.WriteLine(t2);
                }
                t3 = t1 + t2;
                t1 = t2;
                t2 = t3;
                Console.WriteLine(t3);
            }
        }
    }
}
