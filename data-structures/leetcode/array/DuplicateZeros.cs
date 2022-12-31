namespace data_structures.leetcode.array;

public class DuplicateZeros
{
    public static void ChangeArray(int[] arr)
    {
        LinkedList<int> list = new LinkedList<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                list.AddLast(0);
                list.AddLast(0);
            }
            else
            {
                list.AddLast(arr[i]);
            }

            int first = list.First();
            list.RemoveFirst();
            arr[i] = first;

        }
    }
}