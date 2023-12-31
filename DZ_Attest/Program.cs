using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива:");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        string[] Array = new string[arraySize];
        
        Console.WriteLine($"Введите {arraySize} элемента(ов) массива, используя ввод:");
        for (int i = 0; i < arraySize; i++)
        {
            Array[i] = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Первоначальный массив:");
        foreach (var str in Array)
        {
            Console.WriteLine(str);
        }
    }
}