// Задача 2. Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива.
// 4 3 1  =>  4 6 2 
// 2 6 9      2 6 9 
// 4 6 2      4 3 1

using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 5]; 
        Random rnd = new Random(); 
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {   
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(1, 11);
            }

        }
        
        for (int i = 0; i < matrix.GetLength(0); i++)  
        {
            for (int j = 0; j < matrix.GetLength(1); j++)  
            {
                Console.Write(matrix[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }
    
        SwapFirstAndLastRows(matrix);
        Console.WriteLine("Массив после обмена первой и последней строки:");
        PrintArray(matrix);
    }

    static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void SwapFirstAndLastRows(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int col = 0; col < colCount; col++)
        {
            int temp = matrix[0, col];
            matrix[0, col] = matrix[rowCount - 1, col];
            matrix[rowCount - 1, col] = temp;
        }
    }
}
