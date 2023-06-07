// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int m, int n)
{

    int[,] Matrix = new int[m, n];

    int size = Matrix.GetLength(0);
    int currentCount = 1;
    int x = 0, y = 0;
    while (size > 0)
    {
        for (int i = y; i <= y + size - 1; i++)
        {
            Matrix[x, i] = currentCount++;
        }

        for (int j = x + 1; j <= x + size - 1; j++)
        {
            Matrix[j, y + size - 1] = currentCount++;
        }

        for (int i = y + size - 2; i >= y; i--)
        {
            Matrix[x + size - 1, i] = currentCount++;
        }

        for (int i = x + size - 2; i >= x + 1; i--)
        {
            Matrix[i, y] = currentCount++;
        }

        x = x + 1;
        y = y + 1;
        size = size - 2;
       
    }
     return Matrix;
}


void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            System.Console.Write(Matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Matrix = FillMatrix(ReadInt("Введите количество строк A: "), ReadInt("Введите количество столбцов A: "));


PrintMatrix(Matrix);




