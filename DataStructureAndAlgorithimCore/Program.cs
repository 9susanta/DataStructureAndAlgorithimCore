

using InsertionSort;

namespace DataStructureAndAlgorithimCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorith Practice!");
            int[] arr = InsertionSortMaker.GetInsertionSort([3, 5, 6, 2, 9, 6, 5, 8, 1, 0]);



            Console.WriteLine(string.Join(",", arr));
        }
    }
}
