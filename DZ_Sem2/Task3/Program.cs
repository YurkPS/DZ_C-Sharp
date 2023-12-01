//Задача 3: Напишите программу, которая принимает на вход 
//целое число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine());

// Находим наибольшую цифру числа
int maxDigit = 0;
while (number > 0)
{
    int digit = number % 10;
    if (digit > maxDigit)
    {
        maxDigit = digit;
    }
    number /= 10;
}

Console.WriteLine("Наибольшая цифра в числе: " + maxDigit);
