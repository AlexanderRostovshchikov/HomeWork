//Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//строки использовать нельзя

// ВНИМАНИЕ!! Делаю не по примеру, что указан выше, а по условию задачи! В примере ПЯТИзначные числа.

Console.Clear();
Console.WriteLine("Введите шестизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int desiredNumber;
int[] array = new int[6];
if (number < 99999 || number > 1000000)
{
    Console.WriteLine("Неправильное число, перезапустите программу и введите шестизначное число!");
} else
{
    // вычисляю каждую цифру из заданного числа и загоняю ее в массив
    desiredNumber = number / 100000;
    array[0] = desiredNumber;

    desiredNumber = number % 10;
    array[5] = desiredNumber;

    desiredNumber = number / 10000 % 10;
    array[1] = desiredNumber;

    desiredNumber = (number % 100 - number % 10) / 10;
    array[4] = desiredNumber;

    desiredNumber = number / 1000 % 10;
    array[2] = desiredNumber;

    desiredNumber = number % 1000 / 100;
    array[3] = desiredNumber;

    if (Palidrom(array))
    {
        Console.WriteLine($"{number} --> Да!");
    }
    else
        Console.WriteLine($"{number} --> Нет!");
}

bool Palidrom(int[] numbers)
{
    if (numbers[0] == numbers[5] && numbers[1] == numbers[4] && numbers[2] == numbers[3])
        return true;
    else
        return false;
}
