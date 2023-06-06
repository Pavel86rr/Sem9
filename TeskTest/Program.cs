int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int m, int n, int leftRange, int rightRange)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), -9, 10);

void printMatrix(int[,] matrix)
{
    int i, j;
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("\nИсходный массив: ");
printMatrix(matrix);


// Функция, считающая сумму элементов в строке
void SumInLines(int[,] matrix)
{
    int[] sumInLines = new int[matrix.GetLength(0)];
    Console.Write("\nСуммы элементов в каждой строке: ");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumInLines[i] += matrix[i, j];
        }
        Console.Write($"{sumInLines[i]} \t");
    }
    int minI = 0;
    for (int i = 0; i < sumInLines.GetLength(0); i++)
    {
        if (sumInLines[minI] > sumInLines[i])
        { 
        minI = i;
        }
    }
    Console.WriteLine($"\nИндекс строки c наименьшей суммой элементов:  {minI}");
    
}

SumInLines(matrix);






