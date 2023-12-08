// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {        
        int rows = 4;
        int cols = 5;
        
        int[,] array = new int[rows, cols];
        
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.Next(1, 10); 
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int minSumRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");
        Console.WriteLine($"Сумма элементов в этой строке: {minSum}");
    }
}