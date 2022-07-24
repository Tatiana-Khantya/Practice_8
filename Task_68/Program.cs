// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Задайте 2 числа: ");
Console.WriteLine("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int a, int b)
{
    if (a == 0)
    return b + 1;
  else
    if ((a != 0) && (b == 0))
      return AkkermanFunction(a - 1, 1);
    else
      return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
      return 0;
}
int number = AkkermanFunction(a, b);
Console.WriteLine(number);