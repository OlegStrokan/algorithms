namespace data_structures.leetcode.array;

public static class FindDisappearedNumbers
{
    public static IList<int> FindNumbersOwnWay(int[] nums)
        {
            Array.Sort(nums);
            List<int> list = new List<int>();
            List<int> newList = new List<int>();   
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != i + 1)
                {
                    newList.Add(i+1);
                }
            }

            return newList;
        }

    public static IList<int> FindNumbersHashSet(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();
        List<int> missingNumbers = new List<int>();


        for (int i = 0; i < nums.Length; i++)
        {
            hash.Add(nums[i]);
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!hash.Contains(i))
            {
                missingNumbers.Add(i);
            }
        }

        return missingNumbers;
    }

    public static IList<int> FindNumbersBestWay(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++) {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }
        return result;
    }
}