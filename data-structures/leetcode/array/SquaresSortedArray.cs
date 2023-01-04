namespace data_structures.leetcode.array;

public static class SquaresSortedArray
{
    public static int[] SortArray(int[] nums) {
        for(int i = 0; i < nums.Length; i++) {
            nums[i] *= nums[i];
        }
        Array.Sort(nums);
        return nums;
    }
}