using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLPracticeProblems
{
    internal class PerfectNumber
    {
        public static void check()
        {
            {
                int min, max, i, n, sum;
                Console.WriteLine("Find the Ferfect number within a given number of range");
                Console.WriteLine("Input the starting range");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the ending range");
                max = Convert.ToInt32(Console.ReadLine());

                for (n = min; n <= max; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.WriteLine("{0}", n);

                }


            }
        }
    }
}
