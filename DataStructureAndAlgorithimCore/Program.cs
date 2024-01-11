using SelectionSort;

namespace DataStructureAndAlgorithimCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorith Practice!");

            var newArray=SelectionSortAlgo.GetArraySelectionSort([1, 4, 6, 8, 4, 5, 6, 4, 3, 11, 23, 0, -1, 5, 4]);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
