// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

int i = 1;
int a = 3; // a - степень
while (i <= N)
{
    double b = Math.Pow(i, a);
    Console.WriteLine(b);
    i++;
}
