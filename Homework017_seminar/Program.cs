/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[10];
Random rand = new Random();
int sum = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}]");
    }
    else
    {
        Console.Write($"{array[i]}, ");
    }
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.Write($" -> {sum}");
