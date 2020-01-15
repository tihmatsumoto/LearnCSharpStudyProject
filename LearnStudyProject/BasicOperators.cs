using System;
using System.Collections.Generic;
using System.Text;

namespace LearnStudyProject
{
    class BasicOperators
    {
        /* Day 2: Operators */

        public static double CalculateTotalCost(double MealCost, int TipPercentage, int TaxPercentage)
        {
            /*
             double Tip = ((double)TipPercentage / 100) * MealCost;
             double Tax = ((double)TaxPercentage / 100) * MealCost;
             double TotalCost = MealCost + Tip + Tax;

             //In accordance to the exercise provided. Must use Math.Round(TotalCost) to only print int part.
             return TotalCost; 
             */

            return (MealCost * ((double)TipPercentage / 100)) + (MealCost * ((double)TaxPercentage / 100)) + MealCost;
        }

    }
}
