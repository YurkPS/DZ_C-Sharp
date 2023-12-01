//Задача 3. Задайте массив из вещественных чисел с 
//ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным 
//элементом массива.

int arraySize = 10; // размер массива
double[] array = new double[arraySize]; // создаем массив

// заполняем массив случайными вещественными числами с ненулевой дробной частью
Random random = new Random();
Console.WriteLine("Сгенерированные вещественные числа с ненулевой дробной частью:");
for (int i = 0; i < arraySize; i++)
{
    array[i] = random.NextDouble();
    while (array[i] == 0) // проверяем, что число не равно нулю
    {
        array[i] = random.NextDouble();
    }
    Console.WriteLine(array[i]);
}

// находим максимальный и минимальный элементы массива
double max = array[0];
double min = array[0];
for (int i = 1; i < arraySize; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

// выводим найденные значения
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
double difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом: " + difference);
