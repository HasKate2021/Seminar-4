// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

//функция для подсчета суммы элементов нечетных позиций
int IndexSum(int[] num)
{
    int sum = 0;
    for (int index = 0; index < num.Length; index++)
    {
        int m = (index / 2) * 2;
        if (index==m)
        {
            sum += 0;
        }
        else
        {
            sum += num[index];
        }
    }
    return sum;
}

Console.Clear();
int[] massiv = GetArray(8, -10, 99);
Console.WriteLine($"сумма нечётных позиций: {IndexSum(massiv)}");

