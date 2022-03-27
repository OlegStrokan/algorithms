namespace data_structures.sorts;

public partial class Sorts
{
    public int[] BubbleSort(int[] arr)
    {
        foreach (int i in arr) 
        {
            foreach (int j in arr)
            {
                if (arr[j+1] < arr[i])
                {
                    int tmp = arr[i];
                    arr[i] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }
        return arr;
    }
}