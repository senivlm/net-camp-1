using System;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            int[] array = { 1, 2, 3, 3, 3, 2, 2 };
            Console.WriteLine(v.IsPalindrome(array));
            int[] arr = v.Reverse(array);
            for (int o = 0; o < array.Length; o++)
            {
                Console.Write(arr[o]);
            }
            Console.WriteLine("\nstreak:" + v.GetStreak(array));

            int[] array_qs = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int n = 10, i;
            Console.WriteLine("Quick Sort");
            Console.Write("Initial array is: ");
            for (int y = 0; y < n; y++)
            {
                Console.Write(array_qs[y] + " ");
            }
            v.quickSort(array_qs, 0, 9);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array_qs[i] + " ");
            }
        }
        public class Vector
        {
           public bool IsPalindrome(int[] array)
            {
                for (int i = 0; i < array.Length/2; i++)
                {
                    if (array[i] != array[array.Length-1-i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public int[] Reverse(int[] array)
            {
                int[] reversed_array = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    reversed_array[i]=array[array.Length - 1- i];
                }
                return reversed_array;
            }
            public int Partition(int[] arr, int left, int right)
            {
                int pivot;
                pivot = arr[left];
                while (true)
                {
                    while (arr[left] < pivot){left++;}
                    while (arr[right] > pivot){right--;}
                    if (left < right)
                    {
                        int temp = arr[right];
                        arr[right] = arr[left];
                        arr[left] = temp;
                    }
                    else
                    {
                        return right;
                    }
                }
            }
            public void quickSort(int[] arr, int left, int right)
            {
                int pivot;
                if (left < right)
                {
                    pivot = Partition(arr, left, right);
                    if (pivot > 1)
                    {
                        quickSort(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        quickSort(arr, pivot + 1, right);
                    }
                }
            }
            public int GetStreak(int[] array)
            {
                int max_streak = 1;
                int streak = 1;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0)
                    {
                    }
                    else
                    {
                        if (array[i] == array[i-1])
                        {
                            streak++;
                            if (streak > max_streak)
                            {
                                max_streak = streak;
                            }
                        }
                        else if (array[i] != array[i - 1])
                        {
                            streak = 1;
                        }
                    }
                    
                }
                return max_streak;
            }
        }
    }
}
