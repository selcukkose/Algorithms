
using Helpers;
using Sorting;

namespace Testing.Sorting;

public static class InsertionSortTest
{
    public static List<int> Run(List<int> list)
    {
        var timeHelper = new TimeHelper();
        var sortedList = timeHelper.Run(() =>
        {
            return (new InsertionSort()).Sort(list);;
        }, "InsertionSort");
        return sortedList;
    }
}
