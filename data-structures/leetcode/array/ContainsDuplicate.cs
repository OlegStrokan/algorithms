namespace data_structures.leetcode.array;

public static class ContainsDuplicate
{
    public static bool IsContainingByList(int[] nums)
    {
        List<int> list = new List<int>();
        foreach (int i in nums)
        {
            if (list.Contains(i))
            {
                return true;
            }
            list.Add(i);
        }
        return false;
    }

    public static bool IsContaining(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] == nums[j]) {
                    return true;
                }
            }
        }
        return false;
    }
}