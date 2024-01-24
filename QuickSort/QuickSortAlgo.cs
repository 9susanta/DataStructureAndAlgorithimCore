using System.Linq;

namespace QuickSort
{
    public class QuickSortAlgo
    {
        public static int[] QuickSort(int[] numbers)
        {
            if (numbers.Length < 2)
                return numbers;
            else
            {
                int pivot = numbers[0];

                int[] lessSubArray = numbers[1..].Where(x => x <= pivot).ToArray();
                int[] greaterSubArray = numbers[1..].Where(x => x > pivot).ToArray(); 

                return QuickSort(lessSubArray).Append(pivot).Concat(QuickSort(greaterSubArray)).ToArray();
            }
        }
    }
}
