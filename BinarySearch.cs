// Code referenced from: https://www.geeksforgeeks.org/binary-search/
using System;
public class BinarySearch
{
    //Add following to main, uncomment and run
    //// Paste code here as needed
    //int[] bsArr = { 2, 3, 5, 6, 7, 9, 14 };
    //Console.Write("Original Array: ");
    //foreach (int element in bsArr) { Console.Write(element + " "); }
    //Console.WriteLine();
    //// x is the number you are looking for
    //int x = 7;
    //// l keeps track of the left-most index of the collection we're looking at
    //// it starts off at 0, the beginning of the array
    //int l = 0;
    //// r keeps track of the right-most index of the collection we're looking at
    //// it starts off at n-1, the end of the array
    //int r = bsArr.Length - 1;
    //// returns the position where you found x, otherwise returns -1
    //int result = BinarySearch.binarySearch(bsArr, x, l, r);
    //Console.WriteLine("target found at index {0}",result);

    public static int binarySearch(int[] bsArr, int x, int l, int r)
    {
        //Binary Search:
        // *Assumes input data is already sorted
        // *Uses recursion
        // Compare the number to the midpoint of the collection
        // If the number is less than the midpoint, search in the L-half of collection
        // else search in the R-half of the collection

        // Has time complexity of O(log(n)). Since log(n) grows very slowly compared
        // to n, binary search is superior to simple search (which has time complexity of O(n)).

        // as long as r >= to l, there are still elements to look at
        if (r >= l)
        {
            // Set the midpoint
            // while they produce the same answer, use the formula
            // below instead of (l + r) / 2 to prevent overflow
            // (ex.l=200, r=210, if stored in bytes, above would overflow while below would not)
            // note: c# sees OOP below as (1) subtraction, (2) division, (3) addition
            int midpoint = l + (r - l) / 2;

            // Compare x to midpoint of collection
            // if current element matches what we're looking for (x)
            // then stop search and return index
            if (x == bsArr[midpoint])
            {
                return midpoint;
            }
            // if x is less than midpoint, search in L-half of collection
            else if (x < bsArr[midpoint])
            {
                // l edge stays the same, r changes to one space before the midpoint
                return binarySearch(bsArr, x, l, midpoint - 1);
            }
            // else if x is greater than the midpoint, search in R-half of collection
            else
            {
                // l changes to one space ahead of midpoint, r edge stays the same
                return binarySearch(bsArr, x, midpoint + 1, r);
            }
        } // end of if statement

        // if r is less than l at any point, the pointers have flipped
        // and there are no more elements to look at
        // this means x was not found in the array; return -1
        else
        {
            return -1;
        } // end of else statement
    }// end of method
}// end of class
