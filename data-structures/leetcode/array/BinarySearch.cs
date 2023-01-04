namespace data_structures.leetcode.array;

public static class BinarySearch
{
    public static int SearchElement(int[] arr, int target)
    {
        if (arr.Length == 0) return -1;
       
        
        int first = 0;
        int last = arr.Length - 1;

        while (first <= last)
        {
            int middle = (last + first) / 2;

            if (arr[middle] > target)
            {
                last = middle - 1;
            }
            else if (arr[middle] < target)
            {
                first = middle + 1;
            }
            else
            {
                return middle;
            }
        }

        return -1;
    }
}