namespace DailyLeetcode.Solutions.Sorting.Algorithms;

public static class MergeSort
{
    public static int[] SortWithMergeSort(this int[] array)
    {
        if (array.Length == 1)
            return array;

        int mid = (array.Length - 1) / 2;

        var leftArray = array.Where((item, index) => index <= mid).ToArray();
        leftArray =  SortWithMergeSort(leftArray);
        
        var rightArray = array.Where((item, index) => index > mid).ToArray();
        rightArray = SortWithMergeSort(rightArray);

        return Merge(leftArray, rightArray);
    }

    private static int[] Merge(int[] leftArray, int[] rightArray)
    {
        int left = 0, right = 0;
        int[] result = new int[leftArray.Length + rightArray.Length];
        int index = 0;

        while (left < leftArray.Length && right < rightArray.Length)
        {
            if (leftArray[left] < rightArray[right])
                result[index++] = leftArray[left++];
            else
                result[index++] = rightArray[right++];
        }

        while(left < leftArray.Length)
            result[index++] = leftArray[left++];

        while (right < rightArray.Length)
            result[index++] = rightArray[right++];

        return result;
    }
}
