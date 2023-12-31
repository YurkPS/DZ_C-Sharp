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
        
        int IskomStrLength = 3;

        int countIskomStr = 0;
        foreach (var str in Array)
        {
            if (str.Length <= IskomStrLength)
            {
                countIskomStr++;
            }
        }

        string[] NewArray = new string[countIskomStr];
        int index = 0;

        foreach (var str in Array)
        {
            if (str.Length <= IskomStrLength)
            {
                NewArray[index] = str;
                index++;
            }
        }

        Console.Clear();
        Console.WriteLine("Первоначальный массив:");
        foreach (var str in Array)
        {
            Console.WriteLine(str);
        }
        
        Console.WriteLine("\nСледующие элементы массива имеют длину <= 3:");
        foreach (var str in NewArray)
        {
            Console.Write($"{str}" + " ");
            //Console.Write(", ");
        }
    }
}