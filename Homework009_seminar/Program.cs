//Напишите метод, который принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//гугл вежливо предоставил формулу:
//расстояние  = √ ( x B − x A ) 2 + ( y B − y A ) 2 + ( z B − z A ) 2

Console.Clear();
Console.Write("Введите координату xA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату xB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb) {
    double dist = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return dist;
}

double dist = Distance(xa,ya,za,xb,yb,zb);
Console.WriteLine($"А ({xa}, {ya}, {za}); B ({xb}, {yb}, {zb}) -> {dist} ");