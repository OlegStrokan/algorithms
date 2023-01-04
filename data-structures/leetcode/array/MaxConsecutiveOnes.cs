namespace data_structures.leetcode.array;

public static class MaxConsecutiveOnes
{
    public static int FindMax(int[] nums) {
        int maxCount = 0;
        int currentCount = 0;
        
        for(int i = 0; i < nums.Length; i++) {
            if  (nums[i] == 1) {
                currentCount++;
                if  (currentCount > maxCount) {
                    maxCount++;
                }
            } else {
                currentCount = 0;
            }
        }
        return maxCount;
    }
}