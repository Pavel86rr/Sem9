// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadIntA(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[, ,] FillMatrix(int m, int n, int c)
{
    int[, ,] Matrix = new int[m, n, c];

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0;  k < Matrix.GetLength(2); k++)
            {
             Matrix[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
    return Matrix;
}

void PrintMatrix(int[, ,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
            {
             System.Console.Write($"{Matrix[i, j, k]}({i},{j},{k}) \t");
            } 
             System.Console.WriteLine(); 
        }
        System.Console.WriteLine();
    }
}

int[, ,] Matrix = FillMatrix(ReadIntA("Введите  размер матрицы m: "), ReadIntA("Введите  размер матрицы n: "), ReadIntA("Введите  размер матрицы c: "));


PrintMatrix(Matrix);

