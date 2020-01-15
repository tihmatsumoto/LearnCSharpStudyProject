using System;
using System.Collections.Generic;
using System.Text;

namespace LearnStudyProject
{
    class Reviews
    {
        /* Day 6: Review Lesson */
        public static void SeparateChracteres()
        {
            int nOfWords = int.Parse(Console.ReadLine());

            StringBuilder words = new StringBuilder();

            //Words together in the same variable
            for (int i = 0; i < nOfWords; i++)
            {
                words.Append($"{Console.ReadLine()} ");
            }

            StringBuilder even = new StringBuilder();
            StringBuilder odd = new StringBuilder();
            const char SPACE = ' ';

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == SPACE)
                {
                    Console.WriteLine($"{even.ToString()} {odd.ToString()}");
                    even.Clear();
                    odd.Clear();
                    words.Remove(0, i + 1); // Remove word
                    i = -1; // Will be reset to 0 after continue
                    continue;
                }

                if (i % 2 == 0)
                {
                    even.Append(words[i]);
                }
                else
                {
                    odd.Append(words[i]);
                }
            }
        }
    }
}
