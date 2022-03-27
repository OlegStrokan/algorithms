namespace data_structures
{
    public partial class Search
    {
        public int BinarySearch(int key, int[] numbers)
        {
            int low = 0;
            int high = numbers.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (key < numbers[mid])
                {
                    // если элемент меньше середины, то максимальное здачение будет середина - 1 
                    high = mid - 1;
                }
                else if (key > numbers[mid])
                {
                    // если элемент больше середины, то минимальное здачение будет середина + 1 
                    low = mid + 1;
                }
                else return mid;
            }

            return -1;
        }
    }
}