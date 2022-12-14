using DailyLeetcode.Solutions.Extensions;

namespace DailyLeetcode.Solutions.Sorting.Algorithms;

/**
 * Start from 0 position
 * Find the smallest element in an array
 * Move the smallest element to the top position
 * Continue the algo until the position reaches length of array
 * Time complexity - O(n^2)
 * Space complexity - O(1)
**/

public static class SelectionSort
{
    public static void SortWithSelectionSort(this int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            int smallestElementIndex = i;

            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[smallestElementIndex] > array[j])
                {
                    smallestElementIndex = j;
                }
            }

            if (smallestElementIndex != i)
            {
                array.Swap(smallestElementIndex, i);
            }
        }
    }
}