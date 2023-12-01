//Задача 1. Большее из двух чисел

Console.Clear();
Console.Write("Введите первое число: ");
double firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber) 
{
    Console.Write("Первое число '");
    Console.Write(firstNumber);
    Console.Write("' больше чем второе число '");
    Console.Write(secondNumber);
    Console.Write("'");
}
else
{
    if(firstNumber == secondNumber)
    {
        Console.Write("Введенные числа равны '");
        Console.Write(firstNumber);
        Console.Write("'");
    }
    else
    {
    Console.Write("Первое число '");
    Console.Write(firstNumber);
    Console.Write("' меньше чем второе число '");
    Console.Write(secondNumber);
    Console.Write("'");  
    }
}
