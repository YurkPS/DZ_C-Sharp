//Задача 3. Проверка на четность

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if((a % 2) == 0)
{
    Console.Write("Число '");
    Console.Write(a);
    Console.Write("' чётное");
}
else
{
Console.Write("Число '");
Console.Write(a);
Console.Write("' нечётное");
}


Console.WriteLine("Введите длину: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);