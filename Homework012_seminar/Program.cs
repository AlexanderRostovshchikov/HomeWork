/*
Задача 27: Напишите матод, который принимает на вход число и в
ыдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/
Console.Clear();
Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int num;
int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    num = number[i] - '0';
    sum = sum + num;
}
Console.Write($"{number} -> {sum}");
