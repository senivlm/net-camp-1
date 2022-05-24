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
            Console.WriteLine("diagonal down matrix");
            diagonal_down();
            Console.WriteLine("diagonal right matrix");
            diagonal_right();

           
        }
    }
}
