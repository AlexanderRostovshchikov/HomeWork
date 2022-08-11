
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 10;
int b = 7;
int max = a;
int min;
if (b > max) {
    max = b;
    min = a;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.Write(min);
} else {
    min = b;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.Write(min);
}
