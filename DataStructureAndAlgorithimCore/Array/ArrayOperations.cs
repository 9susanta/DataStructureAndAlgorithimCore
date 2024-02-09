using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithimCore.Array
{
    public class ArrayOperations
    {
        public static char[] ArrayReverse(char[] originalArray)
        {
            char[] reverseArray = new char[originalArray.Length];
            int j = 0;
            for(int i = originalArray.Length-1; i >= 0 ; i--)
            {
                reverseArray[j] = originalArray[i];
                j++;
            }
            return reverseArray;
        }
    }
}
