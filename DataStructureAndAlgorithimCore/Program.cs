namespace DataStructureAndAlgorithimCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorith Practice!");
            for (int i = 0; i < 12; i++)
            {
                int k = BinarySearch.BinarySearchAlgo.BinarySearchOperation([1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11], i);

                Console.WriteLine(k);
            }
            
        }
    }
}
