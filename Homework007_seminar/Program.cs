//Задача 15: Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

string DayOfWeek(int number) {
    if(number == 6 || number == 7) {
        return "Да";
    } else return "Нет";
}

string yesOrNot = DayOfWeek(number);
Console.WriteLine(yesOrNot);


