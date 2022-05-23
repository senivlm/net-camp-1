using System;

namespace matrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("spiral matrix");
            spiral();
            Console.WriteLine("snake matrix");
            snake_matrix();
            Console.WriteLine("diagonal matrix");
            diagonal();

            static void diagonal()
            {
                Console.Write("n: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.Write("m: ");
                int m = Int32.Parse(Console.ReadLine());
                int count = n * m;
                int[,] matrix = new int[n, m];

                int x = 0;
                int y = 0;
                int deltaX = 1;
                int deltaY = 0;
                for (int i = 1; i < count; i++)
                {
                    x = x + deltaX;
                    y = y + deltaY;
                    matrix[x, y] = i;
                    if (y == 0 && deltaX == 1 && deltaY == -1 && x != n - 1)
                    {
                        deltaX = 1;
                        deltaY = 0;
                        continue;
                    }
                    if (x == 0 && deltaX == -1 && deltaY == 1 && y != m - 1)
                    {
                        deltaX = 0;
                        deltaY = 1;
                        continue;
                    }
                    if (y == m - 1 && deltaX == -1 && deltaY == 1)
                    {
                        deltaX = 1;
                        deltaY = 0;
                        continue;
                    }
                    if (x == n - 1 && deltaX == 1 && deltaY == -1)
                    {
                        deltaX = 0;
                        deltaY = 1;
                        continue;
                    }

                    if ((x == n - 1 && deltaX == 0) || (y == 0 && deltaY == 0))
                    {
                        deltaX = -1;
                        deltaY = 1;
                        continue;
                    }
                    if ((y == m - 1 && deltaY == 0) || (x == 0 && deltaX == 0))
                    {
                        deltaX = 1;
                        deltaY = -1;
                        continue;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++) Console.Write(matrix[i, j] + " ");
                    Console.WriteLine();
                }
            }

            static int get_n()
            {
                Console.Write("n: ");
                int n = Int32.Parse(Console.ReadLine());

                if (n < 0)
                    throw new Exception("wrong n");
                return n;
            }

            static void print(int[,] array, int n, int m, String name)
            {
                Console.WriteLine(name + ": ");
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            static void snake_matrix()
            {
                int n = get_n();
                int m = n;
                int[,] a = new int[n, m];

                int value = 1;
                for (int i = 0; i < n; ++i)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < m; ++j)
                        {
                            a[i, j] = value;
                            value++;
                        }
                    }
                    else
                    {
                        for (int j = m - 1; j >= 0; --j)
                        {
                            a[i, j] = value;
                            value++;
                        }
                    }
                }

                print(a, n, m, "A");
            }
            static void spiral()
            {
                Console.Write("n :");
                int N = int.Parse(Console.ReadLine());//границы снизу и сверху
                Console.Write("m :");
                int M = int.Parse(Console.ReadLine());//границы слева и спава


                int[,] MM = new int[N, M];
                int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = N;
                int l = MM.Length;
                for (int i = 0; i < l; i++)
                {
                    MM[row, col] = i + 1;

                    if (--gran == 0)
                    {
                        gran = N * (dirChanges % 2) + M * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                        int temp = dy;
                        dy = -dx;
                        dx = temp;
                        dirChanges++;
                    }

                    col += dx;
                    row += dy;
                }

                M = MM.GetLength(1);
                for (int k = 0; k < l; k++)
                    Console.Write("{0}{1,3}", k % M == 0 ? "\n" : "", MM[k / M, k % M]);


                Console.ReadLine();
            }
        }
    }
}
