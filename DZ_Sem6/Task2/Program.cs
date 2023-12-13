//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//С помощью программы на C# сформируйте строку, в которой все 
//заглавные буквы заменены на строчные.

// using System;

// class Program
// {
//     static void Main()
//     {
//         string input = "aBcD1ef!-";
//         string output = ConvertToLowercase(input);
//         Console.WriteLine(output);
//     }

//     static string ConvertToLowercase(string input)
//     {
//         // Создаем массив символов из входной строки
//         char[] array = input.ToCharArray();

//         // Проходим по всем элементам массива
//         for (int i = 0; i < array.Length; i++)
//         {
//             // Проверяем, является ли текущий символ заглавной буквой латиницы
//             if (array[i] >= 'A' && array[i] <= 'Z')
//             {
//                 // Преобразуем его в строчный символ, смещаясь в таблице ASCII на 32 позиции
//                 array[i] = (char)(array[i] + 32);
//             }
//         }

//         // Возвращаем новую строку с помощью созданного массива символов
//         return new string(array);
//     }
// }

//ВТОРОЕ РЕШЕНИЕ
public class Task2
{
public static void Main(string[] args)
{
// Входная строка со смешанными буквами обоих регистров
string input = "aBcD1ef!-";
// Преобразование всех заглавных букв в строчные
string result = input.ToLower();
// Вывод результата
Console.WriteLine(result);
}
}
