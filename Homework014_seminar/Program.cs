/*
помним про задачу повышенной сложности
Написать метод, который генерирует массив 0 и 1 заданного количества N
3 -> 1 1 0
1 0 0
0 0 1
*/

Console.Clear();
Console.WriteLine("Укажите размерность массива: ");
int syzeArray = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
string binary = "";
if (syzeArray > 0)
{
    int[] array = new int[syzeArray];
    Console.Write($"{syzeArray} -> ");
    for (int i = 0; i < syzeArray; i++)
    {
        array[i] = rand.Next(2);
        //Console.Write($"{array[i]} ");
        binary = binary + array[i];
    }
}

/*
Написать метод, принимающий бинарное представление числа
и возвращающее десятиченое представление числа
1 1 0 0 -> 12
1 1 0 1 -> 13
*/



//Console.Write("Введите бинарное представление числа: ");
//string binary = Console.ReadLine();

int Number(string binary)
{
    int number = Convert.ToInt32(binary, 2);
    return number;
}

int num = Number(binary);

Console.WriteLine($"{binary} -> {num}");


/* 
 Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9
10,2 -> 1010
10,8 -> 12
6,6 -> 10

не смог. Вернусь к ней позже.
*/




