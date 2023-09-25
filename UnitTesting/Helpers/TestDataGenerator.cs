namespace UnitTesting.Helpers;

public class TestDataGenerator
{
    public List<int> GenerateListRandomly(int length)
    {
        var list = new List<int>();
        var random = new Random();
        for (int i = 0; i < length; i++)
        {
            list.Add(random.Next(int.MaxValue));
        }

        return list;
    }
}
