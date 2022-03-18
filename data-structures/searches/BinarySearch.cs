namespace data_structures
{
    public static class Search
    {
        public static int BinarySearch(int key, int[] numbers)
        {
            int low = 0;
            int high = numbers.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (key < numbers[mid]) high = mid - 1;
                else if (key > numbers[mid]) low = mid + 1;
                else return mid;
            }

            return -1;
        }
    }
}