namespace SelectionSort
{
    public class SelectionSortAlgo
    {
        public int[] GetArraySelectionSort(int[] array)
        {
            int[] result = new int[array.Length];
            int smallestIndex = 0;
            for(int i = 0; i < array.Length; i++)
            {
                smallestIndex = FindSmallestNumberIndex(array);
                result[i] = array[smallestIndex];
                
            }
        }
        private int FindSmallestNumberIndex(int[] array)
        {
            int small = array[0];
            int smallestIndex = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if (small <= array[i]) 
                {
                smallestIndex = i;
                small = array[i];
                }
            }
            return smallestIndex;
        }
    }
}
