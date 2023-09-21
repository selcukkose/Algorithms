
using Sorting.Helpers;

namespace Sorting;

public class SelectionSort : ISort
{
    public List<int> Sort(List<int> list)
    {
        var array = list.ToArray();

        for (int index = 0; index < array.Length; index++)
        {
            var minValueIndex = GetIndexOfMinValue(array, index);

            if (minValueIndex != index)
            {
                SwapHelper.SwapItemsInArray(array, index, minValueIndex);
            }
        }

        return array.ToList();
    }

    private int GetIndexOfMinValue(int[] array, int index)
    {
        var minIndex = index;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        return minIndex;
    }
}
