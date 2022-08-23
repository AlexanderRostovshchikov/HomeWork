/*
 Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
пример вывода
[1,4,5,3,1,2,3,9]
[4,45,53,31,14,25,63,19]

*/

int[] array = new int [8];
int rand;
Random random = new Random();

Console.Write("[");
for(int i = 0; i < array.Length; i++) {
    rand = random.Next(1,100);
    array[i] = rand;
    if(i == array.Length - 1 ) {
        Console.Write(rand);
    } else Console.Write($"{rand},");
    }
Console.Write("]");
