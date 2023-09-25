using Sorting;
using UnitTesting.Helpers;

namespace UnitTesting.Sorting;

public class SelectionSortTest
{
    private readonly TestDataGenerator _testDataGenerator = new();

    [Fact(DisplayName = "Sort Should Sort Given list Properly")]
    public void Sort_ShouldSort_GivenListProperly()
    {
        foreach (var list in GenerateListOfTestList())
        {
            var expected = new List<int>(list);
            expected.Sort();
            var actual = (new SelectionSort()).Sort(list);
            Assert.Equal(expected, actual);
        }
    }

    private List<List<int>> GenerateListOfTestList()
    {
        return new List<List<int>>()
        {
            _testDataGenerator.GenerateListRandomly(24),
             _testDataGenerator.GenerateListRandomly(24),
              _testDataGenerator.GenerateListRandomly(24),
               _testDataGenerator.GenerateListRandomly(24),
                _testDataGenerator.GenerateListRandomly(14),
                 _testDataGenerator.GenerateListRandomly(45),
                  _testDataGenerator.GenerateListRandomly(64),
                   _testDataGenerator.GenerateListRandomly(1),
                    _testDataGenerator.GenerateListRandomly(2),

        };

    }
}
