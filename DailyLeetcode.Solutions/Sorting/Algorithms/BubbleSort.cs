using DailyLeetcode.Solutions.Extensions;

namespace DailyLeetcode.Solutions.Sorting.Algorithms;

/**
 * In each iteration position starts from 0
 * The most significant element is placed at the end of each iteration
 * Time complexity - O(n^2)
 * Space complexity - O(1)
**/

public static class BubbleSort
{
    public static void SortWithBubbleSort(this int[] array)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    array.Swap(j, j + 1);
                }
            }
        }
    }
}