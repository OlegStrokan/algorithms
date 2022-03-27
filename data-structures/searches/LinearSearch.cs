namespace data_structures;

public partial class Search
{
    public int LinearSearch(int key, int[] arr)
    {
        foreach (int i in arr)
        {
            if (i == key)
            {
                return i;
            }
        }
        return -1;
    }
}