//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0) {
    for (int b = 1; b <= a; b++) {
        if (b%2 == 0) {
            Console.Write($"{b} ");
            if(a - 1 > b) {
                Console.Write(",");
            }
        } 
    }
} else Console.Write("Число должно быть больше нуля"); 

