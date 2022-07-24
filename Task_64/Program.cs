// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
//  = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

Console.Clear();
Console.WriteLine("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    NaturalNumber(n - 1);
}
NaturalNumber(num);