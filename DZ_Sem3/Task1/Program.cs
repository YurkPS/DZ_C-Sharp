//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

bool Sum(int x)
{
    for(int i = 0; i < x; i++)
        if(x > 20 && x < 90)
        return true;
    return false;        
}

void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (Sum(array[i]) == true)
            count ++;
    Console.WriteLine(count);       
}

Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 101);  // [1, 100]
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);
