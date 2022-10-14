using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 10
1. Для заданной матрицы размером 8 на 8 найти такие k, 
что k-я строка матрицы совпадает с k-м столбцом. */

namespace _4_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                { 8, 0, 6, -4, 8, 1, -2, 3 },
                { 4, 1, 36, 7, 8, 2, -5, 8 },
                { 7, 8, 9, 11, 2, 3, 6, -9 },
                { 2, 1, 3, 3, 5, 4, -3, 7 },
                { 3, 0, 6, 7, -8, 5, -8, 5 },
                { 4, 8, 9, 0, -2, 5, -1, 6 },
                { 5, 4, 7, 1, -7, 5, -2, 5 },
                { 8, 1, 5, 3, -3, 7, -9, 2 },
            };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((arr[i, j] == i) && (arr[i, j] == j))
                        Console.WriteLine($"i= {i}, j= {j}, arr[i,j]= {arr[i, j]}");
                }
            }
            Console.ReadKey();
        }
    }
}
