namespace data_structures.sorts;

public partial class Sorts
{
    public List<int> QuickSort(List<int> list)
    {
        if (list.Count <= 1)
        {
            return list;
        }
        // индекс опорного элемента
        int pivotIndex = list.Count / 2;
        // опорный элемент
        int pivot = list[pivotIndex];
        List<int> less = new List<int>();
        List<int> greater = new List<int>();
        foreach (int item in list)
        {
            if (item == pivotIndex)
            {
                continue;
            }

            if (item < pivot)
            {
                less.Add(item);
            }
            else
            {
                greater.Add(item);
            }
        }

        List<int> sorted = QuickSort(less);
        sorted.Add(pivot);
        sorted.AddRange(QuickSort(greater));
        return sorted;
    } 
}