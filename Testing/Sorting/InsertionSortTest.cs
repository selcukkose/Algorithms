using Sorting;

namespace Testing.Sorting;

public static class InsertionSortTest
{
    public static List<int> Run(List<int> list)
    {
        var insertionSort = new InsertionSort();
        return insertionSort.Sort(list);
    }
}
