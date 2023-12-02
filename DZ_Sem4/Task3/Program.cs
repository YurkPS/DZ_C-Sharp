//Задача 3: Напишите программу, которая перевернёт 
//одномерный массив (первый элемент станет последним, 
//второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        // Переворачиваем массив
        ReverseArray(arr);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(arr);
    }

    static void ReverseArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

//Результат выполнения программы будет следующим:
//Исходный массив:
//1 2 3 4 5 
//Перевернутый массив:
//5 4 3 2 1
//Эта программа создает массив с элементами 1, 2, 3, 4 и 5. 
//Затем вызывается функция ReverseArray, которая 
//переворачивает порядок элементов в массиве. И, наконец, 
//функция PrintArray используется для вывода исходного и 
//перевернутого массива на консоль.