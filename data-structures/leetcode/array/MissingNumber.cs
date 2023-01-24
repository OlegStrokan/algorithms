namespace data_structures.leetcode.array;

public static class MissingNumber
{
    public static int ReturnMissingValue(int[] nums)
    {
        List<int> hash = new List<int>(nums);

        for (int i = 0; i < nums.Length; i++) {
            if (!hash.Contains(i)) return i;
        }

        return nums.Length;
    }
}