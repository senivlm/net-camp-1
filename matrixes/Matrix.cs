using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixes
{
    public class Matrix
    {
        private int n;
        private int m;
        private Filling filling; 
        public Matrix(int n, int m, Filling filling)
        {
            this.m = m;
            this.n = n;
            this.filling = filling;
        }
        public void Fill()
        {
            switch (this.filling)
            {
                case Filling.snake:
                {
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

                        Console.WriteLine("A" + ": ");
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < m; ++j)
                            {
                                Console.Write(a[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        Console.Write("\n");
                    }
                    break;

                case Filling.diagonal_right:
                    {
                       
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
                            matrix[y, x] = i;
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
                    break;
                case Filling.diagonal_down:
                    {
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
                    break;
                case Filling.spiral:
                    {

                        int[,] MM = new int[n, m];
                        int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = n;
                        int l = MM.Length;
                        for (int i = 0; i < l; i++)
                        {
                            MM[row, col] = i + 1;

                            if (--gran == 0)
                            {
                                gran = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                                int temp = dy;
                                dy = -dx;
                                dx = temp;
                                dirChanges++;
                            }

                            col += dx;
                            row += dy;
                        }

                        m = MM.GetLength(1);
                        for (int k = 0; k < l; k++)
                            Console.Write("{0}{1,3}", k % m == 0 ? "\n" : "", MM[k / m, k % m]);


                        Console.ReadLine();
                    }
                    break;
            }
        }
       
    }
    public enum Filling:int
    {
        snake,
        diagonal_right,
        diagonal_down,
        spiral

    }
}
