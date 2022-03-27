namespace data_structures.sorts;

public partial class Sorts
{
    public int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int indexMin = i;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] < arr[indexMin])
                {
                    indexMin = j;
                }
            }
            int tmp = arr[i];
            arr[i] = arr[indexMin];
            arr[indexMin] = tmp;
        }
        return arr;
    }
}