// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],2} | ");
            else Console.Write($"{arr[i, j],2} ]");
        }
        Console.WriteLine();
    }
}

int[] SumElemLine(int[,] array)
{
    int sum = 0;
    int[] sumElem = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumElem[i] = 0;
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumElem[i] = sum;
    }
    return sumElem;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int MinElem(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}

int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(arrayResult);
Console.WriteLine();
int[] sumElemArray = SumElemLine(arrayResult);
PrintArray(sumElemArray);
Console.WriteLine();
int min = MinElem(sumElemArray);
Console.WriteLine($"{min + 1} - строкa с наименьшей суммой  элементов ");
// Console.WriteLine(min);
