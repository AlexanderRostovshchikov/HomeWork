//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if(max < b) {
   max = b;
}
if (max < c) {
    max = c;
}
Console.WriteLine($"max = {max}");
