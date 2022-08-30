/*
Написать метод, принимающий бинарное представление числа
и возвращающее десятиченое представление числа
1 1 0 0 -> 12
1 1 0 1 -> 13
*/


Console.Write("Введите бинарное представление числа: ");
string binary = Console.ReadLine();

int Number(string binary)
{
    int number = Convert.ToInt32(binary, 2);
    return number;
}

int num = Number(binary);

Console.WriteLine($"{binary} -> {num}");