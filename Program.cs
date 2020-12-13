using System;
using System.Linq;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input sorted array split numbers by spacebar");
            int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Input number to binary search for in array");
            int numberToLookFor = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(array,numberToLookFor));
            string end = Console.ReadLine();
        }
        public static string BinarySearch(int[] array, int number)
        {
            int currentindex = 0;
            int index = -1;
            int mid = (array.Length - 1) / 2;
            int left = 0;
            int right = array.Length - 1;
            while(index == -1)
            {
                if (number != array[mid])
                {
                    if (number < array[mid])
                    {
                        right = mid;
                        mid = (right + left) / 2;
                        currentindex = mid;
                    }
                    else if (number > array[mid])
                    {
                        left = mid;
                        mid = (left + right) / 2;
                        if(mid + 2 == array.Length)
                        {
                            mid += 1;
                        }
                        currentindex = mid;
                    }
                }
                else
                {
                    index = currentindex;
                }
            }
            return $"The Number is at index [{index}]";
        }
    }
}