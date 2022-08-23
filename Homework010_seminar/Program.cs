/*

Напишите метод, который принимает на вход число (N) и
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

Console.Clear();
Console.WriteLine("Введите число N: ");

int num = Convert.ToInt32(Console.ReadLine());
double a;
for (int i = 1; i <= num; i++)
{
    a = Math.Pow(i, 3);
    if (i == 1)
        Console.Write($"{num} -> ");
    if (i == num)
    {
        Console.Write(a);
    }
    else
        Console.Write($"{a}, ");
}
