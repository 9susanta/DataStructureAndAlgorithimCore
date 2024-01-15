namespace SumArrayDivideNConquer
{
    public class SumArray
    {
        public static int Sum(int[] arr)
        {
            if(arr.Length == 0) return 0;
            else if(arr.Length == 1) return arr[0];
            else
            {
                return arr[0] + Sum(arr[1..]);
            }

        }
    }
}
