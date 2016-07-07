namespace calculator_5.Array
{
    public class BubbleSorting: IArraySorting
    {
        public int[] Sorting(int[] array)
        {
            int gap = array.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int)(gap / 1.247330950103979);

                int i = 0;
                swapped = false;
                while (i + gap < array.Length)
                {
                    if (array[i].CompareTo(array[i + gap]) > 0)
                    {
                        int t = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }
            return array;
        }
    }
}