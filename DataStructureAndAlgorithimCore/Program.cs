
using QuickSort;

namespace DataStructureAndAlgorithimCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorith Practice!");

            int[] numbers = Enumerable.Range(0, 5000).ToArray();
            var sum = QuickSortAlgo.QuickSort(numbers);

            Console.WriteLine(string.Join(",",sum));
        }
    }
}
