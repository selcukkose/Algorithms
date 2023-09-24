
using Sorting.Helpers;

namespace Sorting;

public class BubleSort : ISort
{
    public List<int> Sort(List<int> list)
    {
        if (list == null) return new List<int>();

        var array = list.ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            var isThereAnyChange = PlaceItemToCorrectPosition(array, i);

            if (!isThereAnyChange) break;
        }

        return array.ToList();
    }


    private bool PlaceItemToCorrectPosition(int[] array, int index)
    {
        var isThereAnyChange = false;
        for (int j = 0; j < array.Length - index; j++)
        {
            var nextIndex = j + 1;
            if (nextIndex >= array.Length) break;

            if (array[nextIndex] < array[j])
            {
                SwapHelper.SwapItemsInArray(array, j, nextIndex);
                isThereAnyChange = true;
            }
        }

        return isThereAnyChange;
    }
}
