namespace data_structures.leetcode.array;

public static class FindEventNumber
{
    public static int FindNumber(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Length % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}