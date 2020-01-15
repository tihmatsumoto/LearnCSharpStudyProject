using System;
using System.Collections.Generic;
using System.Text;

namespace LearnStudyProject
{
    class EvenOrOdd
    {
        /* Day 3: Conditional Statements */

        public static void PrintWeirdNotWeird(int N)
        {
            /*
            if (N % 2 == 0)
            {
                if (N >= 2 && N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }
            */

            string output = (N % 2 == 1 || (N >= 6 && N <= 20)) ? "Weird" : "Not Weird";
            Console.WriteLine(output);
        }
        
    }
}
