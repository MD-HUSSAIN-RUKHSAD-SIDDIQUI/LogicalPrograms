using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLPracticeProblems
{
    internal class FibonacciSeries
    {
        public static void Find()
        {
            int n1 = 0, n2 = 1, n, i, totalNum;
            Console.WriteLine("Enter the Number of Elements to be Displayed in Fibonacci Series :");
            totalNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < totalNum; i++)
            {
                n = n1 + n2;
                Console.Write(n + " ");
                n1 = n2;
                n2 = n;
            }
        }
    }
}
