namespace data_structures.leetcode.array;

public static class MissingNumber
{
    public static int ReturnMissingValue(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>(nums);

        for (int i = 0; i < nums.Length; i++) {
            if (!hash.Contains(i)) return i;
        }

        return nums.Length;
    }

    public static int ReturnMissingValueXor(int[] nums)
    {
        int result = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
            result ^= i;
        }

        return result;
    }
}