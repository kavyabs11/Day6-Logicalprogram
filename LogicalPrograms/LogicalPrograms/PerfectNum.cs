using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNum
    {
        public static void Pro()
        {

        
        Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        Console.WriteLine($"The divisors for {n} are");
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
}
Console.WriteLine($"{n} = {sum}");
if (n == sum)
{
    Console.WriteLine($"{n} is a perfect number");
}
else
{
    Console.WriteLine($"{n} is not a perfect number");
}
            }
    }
}
