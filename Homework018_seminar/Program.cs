/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

double[] array = { 3, 7, 22, 2, 78 };

double max = array[0];
double min = array[0];
double diff = 0.0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}] -> ");
    }
    else
    {
        Console.Write($"{array[i]}, ");
    }
}
diff = max - min;

Console.Write(diff);
