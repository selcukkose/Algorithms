namespace Sorting.Helpers;

public static class SwapHelper
{
    public static int[] SwapItemsInArray(int[] array, int indexOne, int indexTwo)
    {
        var value = array[indexOne];
        array[indexOne] = array[indexTwo];
        array[indexTwo] = value;
        return array;
    }
}
