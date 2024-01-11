using System.Linq;

namespace SelectionSort
{
    public class SelectionSortAlgo
    {
        public static int[] GetArraySelectionSort(int[] array)
        {
            int[] result = new int[array.Length];
            int smallestIndex = 0;
            int i = 0;
            while(array.Length!=0)
            {
                smallestIndex = FindSmallestNumberIndex(array);
                result[i]=array[smallestIndex];
                array = array.Where(x=>x!= array[smallestIndex]).ToArray();
                i++;
            }
            return result;
        }
        private static int FindSmallestNumberIndex(int[] array)
        {
            int small = array[0];
            int smallestIndex = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if (small > array[i]) 
                {
                smallestIndex = i;
                small = array[i];
                }
            }
            return smallestIndex;
        }
    }
}
