using System;
using System.Linq;

namespace Binary_Search
{
    class Program
    {
        public static string BinarySearch(int[] array, int number)
        {
            int lastindex = -1;
            int index = -1;
            int mid = (array.Length - 1) / 2;
            int left = 0;
            int right = array.Length - 1;
            while(index == -1)
            {
                if (number != array[mid])
                {
                    lastindex = mid;
                    if (number < array[mid])
                    {
                        right = mid;
                        mid = (right + left) / 2;
                    }
                    else if (number > array[mid])
                    {
                        left = mid;
                        mid = (left + right) / 2;
                        if(mid + 2 == array.Length)
                        {
                            mid += 1;
                        }
                    }
                }
                else 
                { 
                    index = mid;
                }
                if(lastindex == mid)
                {
                   return "Number not found in array";
                }
            }
            return $"The Number is at index [{mid}]";
        }
    }
}
