// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

using System;

class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
        static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите 1-ое число (m): "); 
	    int m = int.Parse(Console.ReadLine()!); 
	    Console.WriteLine("Введите 2-ое число (n): "); 
        int n = int.Parse(Console.ReadLine()!); 
	    Console.WriteLine($"Вывод натуральных чисел от {m} до {n}:");
        PrintNumbers(m, n);
    }
}