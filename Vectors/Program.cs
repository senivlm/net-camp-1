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
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine("\nstreak:" + v.GetStreak(array));

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

            public int GetStreak(int[] array)
            {
                int max_streak = 1;
                int streak = 1;
                int number;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0)
                    {
                        number = array[i];
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
                            number = array[i];
                            streak = 1;
                        }
                    }
                    
                }
                return max_streak;
            }
        }
    }
}
