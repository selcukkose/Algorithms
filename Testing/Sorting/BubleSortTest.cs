using Helpers;
using Sorting;

namespace Testing.Sorting;

public class BubleSortTest
{
    public static List<int> Run(List<int> list)
    {
        var timeHelper = new TimeHelper();
        var sortedList = timeHelper.Run(() =>
        {
            return (new BubleSort()).Sort(list);
        }, "BubleSortTest");
        return sortedList;
    }
}
