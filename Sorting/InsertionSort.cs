
using Sorting.Helpers;

namespace Sorting;

public class InsertionSort : ISort
{
    public List<int> Sort(List<int> list)
    {
        var array = list.ToArray();

        for (int i = 0; i < array.Length; i++)
        {
           var currentindex = i;
           for (int j = i; 0 <= j; j--)
           {
              if (array[currentindex] < array[j]) {
                SwapHelper.SwapItemsInArray(array, j, currentindex);
                currentindex = j;
              }
           }
        }

        return array.ToList();
    }
}
