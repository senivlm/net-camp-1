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

            
            int n = 10, i;
            Console.WriteLine("Quick Sort");

            int[] array_qs0 = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            Console.Write(", Initial array is: ");
            for (int y = 0; y < n; y++)
            {
                Console.Write(array_qs0[y] + " ");
            }
            v.quickSort(array_qs0, 0, 9, 0);
            Console.Write("\nFirst element, Sorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array_qs0[i] + " ");
            }
            int[] array_qs1 = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            v.quickSort(array_qs1, 0, 9, 1);
            Console.Write("\nMiddle element, Sorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array_qs1[i] + " ");
            }
            int[] array_qs2 = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            v.quickSort(array_qs2, 0, 9, 2);
            Console.Write("\nLast element, Sorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array_qs0[i] + " ");
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
            public int Partition(int[] arr, int max, int min, int pivot_position)
            {
                int pivot = arr[max];

                if (pivot_position==0)
                {
                    pivot = arr[min];
                }
                else if (pivot_position == 1)
                {
                    pivot = arr[(max+min)/2];
                }
                else if (pivot_position == 2)
                {
                    pivot = arr[max];
                }
                while (true)
                {
                    while (arr[max] < pivot){max++;}
                    while (arr[min] > pivot){min--;}
                    if (max < min)
                    {
                        int temp = arr[min];
                        arr[min] = arr[max];
                        arr[max] = temp;
                    }
                    else
                    {
                        return min;
                    }
                }
            }//Можна ще задати напрям сортування
            public void quickSort(int[] arr, int left, int right, int pivot_position)
            {
                int pivot;
                if (left < right)
                {
                    pivot = Partition(arr, left, right, pivot_position);
                    if (pivot > 1)
                    {
                        quickSort(arr, left, pivot - 1, pivot_position);
                    }
                    if (pivot + 1 < right)
                    {
                        quickSort(arr, pivot + 1, right, pivot_position);
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
