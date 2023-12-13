// Задача 3: Задайте произвольный массив. 
// Выведите его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделённые пробелом:");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(input, int.Parse);
        PrintArrayInReverse(numbers, numbers.Length - 1);
    }

    static void PrintArrayInReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);
        PrintArrayInReverse(array, index - 1);
    }
}