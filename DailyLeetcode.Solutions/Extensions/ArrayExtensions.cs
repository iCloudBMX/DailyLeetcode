namespace DailyLeetcode.Solutions.Extensions;

public static class ArrayExtensions
{
    public static void Swap(this int[] array, int position1, int position2)
    {
        int temp = array[position1];
        array[position1] = array[position2];
        array[position2] = temp;
    }

    public static void Print(this int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}