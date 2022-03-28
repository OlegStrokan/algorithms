namespace data_structures
{
    public partial class Search
    {
        int count = 0;

        public int BinarySearch(int item, int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (item < arr[mid])
                {
                    // если элемент меньше середины, то максимальное здачение будет середина - 1 
                    high = mid - 1;
                }
                else if (item > arr[mid])
                {
                    // если элемент больше середины, то минимальное здачение будет середина + 1 
                    low = mid + 1;
                }
                else return mid;
            }

            return -1;
        }

        // через рекурсию
        public int RecursiveBinarySearch(int[] arr, int item, int start, int end)
        {
            int middle = (start + end) / 2;
            count += 1;

            if (item == arr[middle])
            {
                return middle;
            }

            if (item > arr[middle])
            {
                return RecursiveBinarySearch(arr, item, middle - 1, end);
            }
            else
            {
                return RecursiveBinarySearch(arr, item, middle + 1, end);
            }
        }
    }
}