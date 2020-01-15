using System;
using System.Collections.Generic;
using System.Text;

namespace LearnStudyProject
{
    class Arrays
    {
        /* Day 7: Array*/

        public static void ReverseArray()
        {
            //Reverse an array
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            //Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ", arr));

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{arr[i]} ");
            }
        }
    }
}
