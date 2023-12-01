//Задача 2. Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество 
//чётных чисел в массиве.

bool CountEventNumbers(int x)
{
    for(int i = 0; i < x; i++)
        if(x % 2 ==0)
        return true;
    return false;        
}

void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (CountEventNumbers(array[i]) == true)
            count ++;
    Console.WriteLine(count);       
}

Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 101);  // [1, 100]
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);
