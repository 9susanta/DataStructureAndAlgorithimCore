
using QuickSort;

namespace DataStructureAndAlgorithimCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorith Practice!");

            var sum = QuickSortAlgo.QuickSort([1, 7, 3,0,6,8,2]);
            Console.WriteLine(string.Join(",",sum));

        }
    }
}
