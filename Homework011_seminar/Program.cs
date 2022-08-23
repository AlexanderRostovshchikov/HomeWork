/*Напишите метод, который принимает на 
вход два числа (A и B) и возводит число A в
 натуральную степень B.
нельзя использовать pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
Console.WriteLine("Введите число А, вовзводимое в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число, в какую степень возводить число {a}");
int b = Convert.ToInt32(Console.ReadLine());

int num = a;

for(int i = 1; i < b; i++) {
    if(i==1) {
        Console.Write($"{a}, {b} -> ");
    }
    num = num * a;
}
Console.Write(num);
