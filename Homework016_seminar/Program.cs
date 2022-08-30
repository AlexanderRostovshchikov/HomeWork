/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[10];
Random rand = new Random();
int count = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}]");
    }
    else
    {
        Console.Write($"{array[i]}, ");
    }
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write($" -> {count}");
