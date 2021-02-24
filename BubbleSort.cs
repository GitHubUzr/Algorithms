// Code referenced from: https://github.com/ISM6225/Sort/blob/master/Sort/Program.cs
using System;
public class BubbleSort
{
    // Add following to main and run
    //int[] bsArr = { 22, 3, 77, 16, 777, 6, 9, 43, 899, 7 };
    //Console.Write("Original Array: ");
    //foreach (int element in bsArr) { Console.Write(element + " "); }
    //BubbleSort.bubbleSort(bsArr);
    //Console.Write(Environment.NewLine + "Sorted Array: ");
    //foreach (int element in bsArr) { Console.Write(element + " "); }

    //Note: This method modifies the original array, so there is nothing to return.
    public static void bubbleSort(int[] bsArr)
    {

        //Bubble Sort:
        // The outer for loop will continue until the array is sorted in ascending order.
        // Bubble Sort starts from the beginning of the array each for loop iteration and checks the value
        // of the next element in the array to see if it is less. If it is less, then swap.

        // Since there are two nested loops in this algorithm, we would
        // describe its time complexity(or Big O notation) as O(n ^ 2).

        // Loops until penultimate list element (n-1 times), since inner loop is looking one space ahead
        for (int i = 0; i < bsArr.Length - 1; i++)
        {
            // Starting from index 0, look at current element and compare it to the element one space ahead.
            // After inner loop is finished, outer loop increases i by 1. Since swap moves largest value
            // to the back, you ignore that value and reduce your comparison range by 1.
            for (int x = 0; x < bsArr.Length - i - 1; x++)
            {
                // In each nested for loop iteration check to see if the current element value is greater than the next element value
                // If the current element value is greater, then conduct the swap
                if (bsArr[x] > bsArr[x + 1])
                {
                    // Here you will swap temp and bsArr[x]
                    // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                    int temp = bsArr[x];
                    bsArr[x] = bsArr[x + 1];
                    bsArr[x + 1] = temp;
                }// end of if statement
            }// end of inner loop
        }// end of outer loop
    }// end of method
}// end of class
