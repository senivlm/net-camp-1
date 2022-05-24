using System;

namespace matrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("spiral matrix");
            Matrix matrix1 = new Matrix(6, 6, Filling.spiral);
            matrix1.Fill();
            Console.WriteLine("snake matrix");
            Matrix matrix2 = new Matrix(6, 6, Filling.snake);
            matrix2.Fill();
            Console.WriteLine("diagonal down matrix");
            Matrix matrix3 = new Matrix(6, 6, Filling.diagonal_down);
            matrix3.Fill();
            Console.WriteLine("diagonal right matrix");
            Matrix matrix4 = new Matrix(6, 6, Filling.diagonal_right);
            matrix4.Fill();


        }
    }
}
