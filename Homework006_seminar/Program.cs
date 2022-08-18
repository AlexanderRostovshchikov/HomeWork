//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number != null) {
    int length = number.Length;
    for (int i = 0; i < length; i++) {
        if(i == 2) {
            Console.WriteLine(number[i]);
            break;
        }
        if(length<=2) {
            Console.WriteLine("третьей цифры нет");
            break;
        }
        i++;
    }
}