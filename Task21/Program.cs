// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("X1");
int X1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Y1");
int Y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Z1");
int Z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки В");
Console.WriteLine("X2");
int X2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Y2");
int Y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Z2");
int Z2 = int.Parse(Console.ReadLine()!);

int AB = X2 - X1;
int AD = Y2 - Y1;
int AE = Z2 - Z1;

double a = AB * AB;
double b = AD * AD;
double c = AE * AE;
double d = a + b + c;

double e = Math.Round((Math.Sqrt(d)), 2);

Console.WriteLine($"Расстояние между точками AB --> {e}");