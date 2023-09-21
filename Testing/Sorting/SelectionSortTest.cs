using Sorting;

namespace Testing.Sorting;

public static class SelectionSortTest
{
    public static List<int> Run(List<int> list)
    {
        var selectionSort = new SelectionSort();
        return selectionSort.Sort(list);
    }
}
