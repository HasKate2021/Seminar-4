// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//функция создания массива из рандомных чисел
int [] GetArray(int size, int minValue, int maxValue)
{
int [] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(minValue, maxValue + 1);
Console.Write($"{array[i]} ");
}
return array;
}

//функция вычисления суммы четных чисел
int Chetni (int [] calc)
{
    int count = 0;
    foreach (int el in calc)
    {
        int m=(el/2)*2;
        if (el == m)
        {
           count+= 1; 
        }
        else
        {
            count+= 0;
        }
    }
    return count;
}

Console.Clear();
int [] massiv = GetArray(4, 100, 999);
//Console.WriteLine($"{massiv}");
Console.WriteLine($"количество чётных чисел: {Chetni(massiv)}");
