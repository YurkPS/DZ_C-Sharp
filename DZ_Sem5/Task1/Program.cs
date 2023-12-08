//Задача 1: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.
// 4 3 1  (1,2) => 9 
// 2 6 9

using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int rows = random.Next(1, 10);
        int columns = random.Next(1, 10);
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(100); 
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Введите индекс i:");
        int Row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите индекс j:");
        int Column = Convert.ToInt32(Console.ReadLine());

        if (Row >= 0 && Row < rows && Column >= 0 && Column < columns)
        {
            Console.WriteLine($"Значение элемента на позиции ({Row}, {Column}) равно {array[Row, Column]}");
        }
        else
        {
            Console.WriteLine("Элемента с такими индексами в массиве нет.");
        }
    }
}