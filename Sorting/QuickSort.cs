
using Sorting.Helpers;

namespace Sorting;

public class QuickSort : ISort
{
    public List<int> Sort(List<int> list)
    {
        var array = list.ToArray();
        RunSort(array, 0, list.Count);
        return array.ToList();
    }

    private void RunSort(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var pivotIndex = SortPartion(array, lowIndex, highIndex);
            RunSort(array, lowIndex, pivotIndex);
            RunSort(array, pivotIndex + 1, highIndex);
        }
    }

    private int SortPartion(int[] array, int lowIndex, int highIndex)
    {
        var pivotIndex = lowIndex;
        var pivotValue = array[pivotIndex];
        var leftwall = lowIndex;

        for (int i = lowIndex + 1; i < highIndex; i++)
        {
            if (array[i] < pivotValue)
            {
                SwapHelper.SwapItemsInArray(array, leftwall, i);
                if (leftwall == pivotIndex)
                    pivotIndex = i;
                leftwall = leftwall + 1;
            }
        }
        
        SwapHelper.SwapItemsInArray(array, leftwall, pivotIndex);

        return leftwall;
    }
}
