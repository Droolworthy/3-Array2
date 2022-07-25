//Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся. 
//Вывести наибольший элемент, исходную и полученную матрицу.
//Массив под измененную версию не нужен.
using System;

namespace CS21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
            int maxElement = 0;
            
            Console.WriteLine("Вывод массива:");
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Наибольший элемент массива - " + maxElement + ".");
            Console.WriteLine();
            Console.WriteLine("Вывод изменённого массива:");
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == maxElement)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
