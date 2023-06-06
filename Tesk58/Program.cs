// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int ReadInt(string text)
// {
//   System.Console.Write(text);
//   return Convert.ToInt32(Console.ReadLine());
// }

int ReadIntA(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrixA(int m, int n)
{
    int[,] MatrixA = new int[m, n];

    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixA.GetLength(1); j++)
        {
            MatrixA[i, j] = new Random().Next(-10, 11);
        }
    }
    return MatrixA;
}






void PrintMatrixA(int[,] MatrixA)
{
    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixA.GetLength(1); j++)
        {
            System.Console.Write(MatrixA[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixA = FillMatrixA(ReadIntA("Введите количество строк A: "), ReadIntA("Введите количество столбцов A: "));
//int[,] MatrixB = FillMatrixB(ReadInt("Введите количество строк B: "), ReadInt("Введите количество столбцов B: "));
PrintMatrixA(MatrixA);


int ReadIntB(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrixB(int m, int n)
{
    int[,] MatrixB = new int[m, n];

    for (int i = 0; i < MatrixB.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            MatrixB[i, j] = new Random().Next(-10, 11); ;
        }
    }
    return MatrixB;
}

void PrintMatrixB(int[,] MatrixB)
{
    for (int i = 0; i < MatrixB.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            System.Console.Write(MatrixB[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}



int[,] MatrixB = FillMatrixB(ReadIntB("Введите количество строк B: "), ReadIntB("Введите количество столбцов B: "));
System.Console.WriteLine();
PrintMatrixB(MatrixB);
System.Console.WriteLine();


void CompMatrix(int[,] MatrixA, int[,] MatrixB)
{
    int[,] CompMatrix = new int[5, 5];

    if (MatrixA.GetLength(0) != MatrixB.GetLength(1))
    {
        System.Console.WriteLine("Число столбцов перавой матрицы не равно числу строк второй, следовательно их произведение не существует");
        return;
    }
    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {

        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            CompMatrix[i, j] = 0;
            for (int k = 0; k < MatrixA.GetLength(1); k++)
            {
                CompMatrix[i, j] = CompMatrix[i, j] + (MatrixA[i, k] * MatrixB[k, j]);


            }
            System.Console.Write($" {CompMatrix[i, j]}  \t");

        }
        System.Console.WriteLine();
    }
}

CompMatrix(MatrixA, MatrixB);

