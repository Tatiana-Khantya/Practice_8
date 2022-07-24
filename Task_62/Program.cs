// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FullMatrixSpiral(int m, int n)
{
    int[,] spiral = new int[m, n];
    int num = 1;
    for (int delta = 0; delta < spiral.GetLength(0) - delta; delta++)
    {
        for (int i = 0 + delta; i < spiral.GetLength(0) - delta; i++)
        {
            spiral[0 + delta, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + delta; i < spiral.GetLength(0) - delta; i++)
        {
            spiral[i, spiral.GetLength(0) - 1 - delta] = num;
            num++;
        }
        num--;
        for (int i = spiral.GetLength(0) - 1 - delta; i >= 0 + delta; i--)
        {
            spiral[spiral.GetLength(0) - 1- delta, i] = num;
            num++;
        }
        num--;
        for (int i = spiral.GetLength(0) - 1 - delta; i >= 1 + delta; i--)
        {
            spiral[i, 0 + delta] = num;
            num++;
        }
    }
    return spiral;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],2} | ");
            else Console.Write($"{arr[i, j],2} |");
        }
        Console.WriteLine();
    }
}
int[,] newMatrix = FullMatrixSpiral(4, 4);
PrintMatrix(newMatrix);