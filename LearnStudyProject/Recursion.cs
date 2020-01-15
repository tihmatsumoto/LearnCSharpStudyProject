using System;
using System.Collections.Generic;
using System.Text;

namespace LearnStudyProject
{
    class Recursion
    {
        /* Day 9: Recursion */
        public static int Factorial(int n)
        {
            /* int fact = 1;
            for(int i=1; i <= n;i++)
            {
                fact = fact * i;
            } */

            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
