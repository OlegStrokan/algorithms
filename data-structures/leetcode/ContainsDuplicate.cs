namespace data_structures.leetcode;

public static class ContainsDuplicate
{
    public static bool IsContaining(int[] numbers)
    {
        List<int> list = new List<int>();
        foreach (int i in numbers)
        {
            if (list.Contains(i))
            {
                return true;
            }
            list.Add(i);
        }
        return false;
    }
}