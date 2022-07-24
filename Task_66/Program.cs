// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Задайте два числа: ");
Console.WriteLine("Число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число N = ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int n, int m)
{
    if (n > m) return n + SumNumber(n - 1, m);

    if (n < m) return n + SumNumber(n + 1, m);

    if (n == m) return m;
    return 0;
}
int sum = SumNumber(n, m);
Console.WriteLine(sum);