namespace BinarySearch
{
    public class BinarySearchAlgo
    {
        public static int BinarySearchOperation(int[] list,int item)
        {
            int low=0, high=list.Length-1;
            int mid = 0;
            int guess = 0;
            while (low<=high)
            {
                mid=(low+high)/2;
                guess = list[mid];

                if (guess==item)
                {
                    return mid;
                }
                else if (guess<item)
                {
                    low = mid+1;
                }
                else
                {
                    high = mid-1;
                }

            }
            return -1;
        }
    }
}
