// Code referenced from: https://github.com/ISM6225/Sort/blob/master/Sort/Program.cs
using System;
public class SelectionSort
{
    //Add following to main and run
    //int[] ssArr = { 7, 45, 4, 12, 22, 555, 1, 2, 999, 7 };
    //Console.Write("Original Array: ");
    //foreach (int element in ssArr) { Console.Write(element + " "); }
    //SelectionSort.selectionSort(ssArr);
    //Console.Write(Environment.NewLine + "Sorted Array: ");
    //foreach (int element in ssArr) { Console.Write(element + " "); }

    //Note: This method modifies the original array, so there is nothing to return.
    public static void selectionSort(int[] ssArr)
    {
        //Selection Sort:
        // Scans all elements in array and identify the smallest (min).
        // Once min element is located, swap it with the first element.
        // Repeat this selection sort process on the remaining N-1 elements using an iterative loop.

        // Since there are two nested loops in this algorithm, we would
        // describe its time complexity(or Big O notation) as O(n ^ 2). The advantage it
        // has over the Bubble Sort is that it never makes more than O(n) swaps.
        // So, less data is required to write to memory during the swap process.

        // minPosition is used to keep track of the element position with the current lowest value
        int minPosition;
        // temp is used to conduct the swap during during the Selection Sort Algorithm
        int temp;

        // Looks at every item in list (loops n times)
        for (int i = 0; i < ssArr.Length; i++)
        {
            // Initialize the minPosition to the current index of array
            minPosition = i;

            // From the minPosition, check to see if any of the following elements are smaller.
            // After inner loop is finished, outer loop increases i by 1. Since swap moves
            // smallest value to the front, you ignore that value and reduce your search range by 1.
            for (int x = i + 1; x < ssArr.Length; x++)
            {
                // if the next element from the current min_position is smaller, then make that the new minPosition
                if (ssArr[x] < ssArr[minPosition])
                {
                    //minPosition will keep track of the index that min is in, this is needed when a swap happens
                    minPosition = x;
                }
            } // end of inner loop
              // If the minPosition is not at front (does not equal the current element being evaluated in the loop, i)
              // Then execute the swap, switching the position of the lowest with the current element
            if (minPosition != i)
            {
                temp = ssArr[i];
                ssArr[i] = ssArr[minPosition];
                ssArr[minPosition] = temp;
            } // end of if statement
        } // end of outer loop
    }// end of method
}// end of class

