using System;
// Code referenced from: https://www.geeksforgeeks.org/0-1-knapsack-problem-dp-10/
public class KnapsackRecursion
{   // Paste, Uncomment and Run following
    // in Main method from Program.cs
    //int[] val = new int[] { 60, 100, 120 };
    //int[] wt = new int[] { 10, 20, 30 };
    //int w = 50;
    //int n = val.Length;
    //Console.WriteLine(KnapsackRecursion.knapSackR(w, wt, val, n));

    //Knapsack Problem
    // Given a series of n items, each with an associated weight and value
    // And a knapsack that can hold w weight worth of items 
    // Find the maximum value the knapsack can obtain


    //Recursive solution
    // Has O(2^n) time complexity (as there are redundancies)
    public static int knapSackR(int w, int[] wt, int[] val, int n)
    {
        // if done looking though all items (n) or weight
        // limit (w) has been reached stop and return 0
        if (n == 0 || w == 0)
        {
            return 0;
        }
        // if weight of the nth item is more than knapsack capacity w,
        // then this item cannot be included in the optimal solution
        if (wt[n - 1] > w)
        {
            return knapSackR(w, wt, val, n - 1);
        }
        // consider both cases: (1) nth item included, (2) not included
        // and return the one with the max value
        else
        {
            int temp1 = val[n - 1] + knapSackR(w - wt[n - 1], wt, val, n - 1);
            int temp2 = knapSackR(w, wt, val, n - 1);
            return Math.Max(temp1, temp2);
        }// end of else statement
    }// end of method

}
