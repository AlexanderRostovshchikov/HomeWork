//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого 
//числа.

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
if (number.Length == 3 ) {
    Console.WriteLine(number[1]);
} else Console.WriteLine("Введено не трехначное число!");