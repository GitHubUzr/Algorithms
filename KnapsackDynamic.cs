// Code referenced from: https://www.geeksforgeeks.org/0-1-knapsack-problem-dp-10/
using System;
public class KnapsackDynamic
{
	// Paste, Uncomment and Run following
	// in Main method from Program.cs
	//int[] val = new int[] { 100, 120, 60 };
	//int[] wt = new int[] { 3, 2, 1 };
	//int W = 5;
	//int n = val.Length;
	//Console.WriteLine(KnapsackDynamic.knapSackDy(W, wt, val, n));

	//Knapsack Problem
	// Given a series of n items, each with an associated weight and value
	// And a knapsack that can hold w weight worth of items 
	// Find the maximum value the knapsack can obtain

	//Dynamic Programming Solution
	// Has O(n*W) time complexity
	public static int knapSackDy(int W, int[] wt, int[] val, int n)
	{
		// create 2-D array, K[,]
		// with n-rows, each row looking at n-first items, (+1 row to prevent i-1 error)
		// and W-columns, each column looking at a max-weight subproblem (+1 column for weight 0)
		int[,] K = new int[n + 1, W + 1];

		// for each item...
		for (int i = 0; i <= n; i++)
		{
			// for each max-weight...
			for (int w = 0; w <= W; w++)
			{
				// if first row or column, set value to zero
				if (i == 0 || w == 0)
				{
					//Console.WriteLine("K[{0},{1}] = {2}", i, w, 0);
					K[i, w] = 0;
				}
				// can current item (with its weight) fit in the knapsack (at this max weight value)?
				// if item fits in knapsack...
				else if (wt[i - 1] <= w)
				{
					// do we use the item in the row we’re sitting in, or do we not?
					// if using item...
					// take value of current item + stored value(s) needed to reach max-weight
					int temp1 = val[i - 1] + K[i - 1, w - wt[i - 1]];
					// if not using item...
					// take value of previous cell (prev row, same column) where we did not consider current item
					int temp2 = K[i - 1, w];
					// fill cell with the option that has the highest value
					//Console.WriteLine("K[{0},{1}] = {2}", i, w, Math.Max(temp1, temp2));
					K[i, w] = Math.Max(temp1, temp2);
				}
				// if item does not fit in knapsack...
				else
				{
					// take value of previous cell (prev row, same column) where we did not consider current item
					//Console.WriteLine("K[{0},{1}] = {2}", i, w, K[i - 1, w]);
					K[i, w] = K[i - 1, w];
				}// end of else statement
			}// end of inner for loop
		}// end of outer for loop

		// return value of last cell in table
		// which considers all items at max weight W
		return K[n, W];

	}// end of method
}// end of class
