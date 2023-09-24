using Helpers;
using Sorting;

namespace Testing.Sorting;

public static class SelectionSortTest
{
    public static List<int> Run(List<int> list)
    {
        var timeHelper = new TimeHelper();
        var sortedList = timeHelper.Run(() =>
        {
            return (new SelectionSort()).Sort(list);;
        }, "SelectionSort");
        return sortedList;
    }
}
