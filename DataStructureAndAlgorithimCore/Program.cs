

using DataStructureAndAlgorithimCore.Array;
using InsertionSort;

namespace DataStructureAndAlgorithimCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorith Practice!");
            char[] arr = ArrayOperations.ArrayReverse(("Susanta Kumar Rout").ToArray());



            Console.WriteLine(string.Join("", arr));
        }
    }
}
