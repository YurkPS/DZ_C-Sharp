//Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         string inputString = "Аргентина манит негра"; // Пример произвольной строки
//         string processedString = RemoveSpecialCharacters(inputString.ToLower());
        
//         bool isPalindrome = IsPalindrome(processedString);
//         if (isPalindrome)
//             Console.WriteLine($"Строка \"{inputString}\" является палиндромом.");
//         else
//             Console.WriteLine($"Строка \"{inputString}\" не является палиндромом.");
//     }
    
//     static string RemoveSpecialCharacters(string str)
//     {
//         char[] arr = str.ToCharArray();

//         arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c))));
//         return new string(arr);
//     }

//     static bool IsPalindrome(string str)
//     {
//         int min = 0;
//         int max = str.Length - 1;
//         while (true)
//         {
//             if (min > max)
//             {
//                 return true;
//             }
//             char a = str[min];
//             char b = str[max];
//             if (char.ToLower(a) != char.ToLower(b))
//             {
//                 return false;
//             }
//             min++;
//             max--;
//         }
//     }
// }


//ВТОРОЕ РЕШЕНИЕ:
public class Task3
{
public static void Main(string[] args)
{
// Входная строка для проверки
string input = "шалаш";
// Вызов метода для проверки, является ли строка палиндромом
bool isPalindrome = IsPalindrome(input);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
// Метод для проверки, является ли строка палиндромом
public static bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}
}