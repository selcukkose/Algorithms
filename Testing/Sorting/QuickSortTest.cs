
using Helpers;
using Sorting;

namespace Testing.Sorting;

public static class QuickSortTest
{
    public static List<int> Run(List<int> list)
    {
        var timeHelper = new TimeHelper();
        var sortedList = timeHelper.Run(() =>
        {
            return (new QuickSort()).Sort(list);;
        }, "QuickSort");
        return sortedList;
    }
}
