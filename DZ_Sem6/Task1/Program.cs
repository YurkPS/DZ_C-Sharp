// //Задача 1. Задайте двумерный массив символов (тип char [,]). 
// //С помощью программы на C# cоздать строку из символов этого массива.


// using System;
// using System.Text; // Необходимо для работы с классом StringBuilder

// class Program
// {
//     static void Main()
//     {
//         // Создаем и инициализируем двумерный массив символов
//         char[,] charArray = {
//             { 'H', 'e', 'l', 'l', 'o' },
//             { 'W', 'o', 'r', 'l', 'd' }
//         };

//         // Создаем StringBuilder для эффективного построения строки
//         StringBuilder sb = new StringBuilder();

//         // Проходимся по всем элементам двумерного массива
//         for (int i = 0; i < charArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < charArray.GetLength(1); j++)
//             {
//                 // Добавляем символ в StringBuilder
//                 sb.Append(charArray[i, j]);
//             }
//         }

//         // Преобразуем StringBuilder в строку
//         string resultString = sb.ToString();

//         // Выводим результат
//         Console.WriteLine(resultString);
//     }
// }



//ВТОРОЕ РЕШЕНИЕ
public class Task1
{
public static void Main(string[] args)
{
// Инициализация двумерного массива символов
char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
// Вызов метода для создания строки из 2D массива
string result = CreateStringFrom2DArray(charArray);
// Вывод результата
Console.WriteLine(result);
}
// Метод для создания строки из двумерного массива символов
public static string CreateStringFrom2DArray(char[,] array)
{
string result = "";
// Цикл по каждому элементу в двумерном массиве
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
// Добавление каждого символа в результирующую строку
result += array[i, j];
}
}
return result;
}
}