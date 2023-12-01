//Задача 4: Напишите программу, которая на вход
//принимает натуральное число N, а на выходе 
//показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Цифры числа {0}: ", n);

string numberString = n.ToString();

for (int i = 0; i < numberString.Length; i++)
{
    Console.Write(numberString[i]);
    if (i < numberString.Length - 1)
    {
        Console.Write(", ");
    }
}
