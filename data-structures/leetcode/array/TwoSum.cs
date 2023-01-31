namespace data_structures.leetcode.array;

public static class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(target -nums[i]))
            {
                return new int[] {  dictionary[target - nums[i]],i };
            }
            else
            {
                dictionary[nums[i]] = i;
            }
           
        }
        return null;
    }
}