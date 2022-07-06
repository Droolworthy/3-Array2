using System;

namespace CS21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = {{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
            int maxElement = 0;
            
            Console.WriteLine("Вывод массива:");
            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (maxElement < A[i, j])
                    {
                        maxElement = A[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Наибольший элемент массива - " + maxElement + ".");
            Console.WriteLine();
            Console.WriteLine("Вывод изменённого массива:");
            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == maxElement)
                    {
                        A[i, j] = 0;
                    }
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}