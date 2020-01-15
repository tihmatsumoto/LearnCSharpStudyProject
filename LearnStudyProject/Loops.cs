using System;
using System.Collections.Generic;
using System.Text;

namespace LearnStudyProject
{
    class Loops
    {
        /* Day 5: Loops */
        public static void CalculaMultiplo(int n)
        {

            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(n + " x " + i + " = " + n * i);
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
                Console.WriteLine($"{n} x {i} = {n * i}");

            }
        }
    }
}
