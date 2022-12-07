// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int N = int.Parse(Console.ReadLine()!);
int a = N % 10;
int b = N / 1000;

while (N > 12320)
{
    N = N / 10;
}

int d = N % 10;
int e = (a * 10) + d;

if (b == e)
    Console.WriteLine("да");

else
    Console.WriteLine("нет");
