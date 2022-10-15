//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.

//функция создания массива из рандомных чисел
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}

//функция нахождения min
int Min(int[] num)
{
    int min = num[0];
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] < min)
        {
            min = num[i];
        }
        //Console.Write($"{min} ");
    }
    return min;
}

//функция нахождения max
int Max(int[] num)
{
    int max = num[0];
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > max)
        {
            max = num[i];
        }
        //Console.Write($"{max} ");
    }
    return max;
}

Console.Clear();
int[] massiv = GetArray(8, -100, 99);
int minCh=Min(massiv);
int maxCh=Max(massiv);
Console.WriteLine($"Минимальное число: {minCh}");
Console.WriteLine($"Максимальное число: {maxCh}");
Console.WriteLine($"разница чисел: {maxCh-minCh}");