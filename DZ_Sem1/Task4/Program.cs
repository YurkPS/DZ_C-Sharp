//ЗАДАЧА 4. Вывести четные числа

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Чётные числа: ");    

for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
    {
        Console.Write('\t');Console.Write(i);
    }    


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
