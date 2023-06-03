//Задача 57: Составить частотный словарь элементов 
//двумерного массива. Частотный словарь содержит 
//информацию о том, сколько раз встречается элемент входных данных.

bool CheckArray(int[] array, int number, int index_array)
{
    for (int i = 0; i < index_array + 1; i++)
        if (array[i] == number)
            return false;
    return true;

}


void InputMatrix(int[,] matrix, int[] array, ref int index_array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);  //[1;10]
            if (CheckArray(array, matrix[i, j], index_array))
            {
                array[index_array] = matrix[i, j];
                index_array++ ;
            }
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


void MatrixCounter(int[] array, int[,] matrix, int size_array)
{
    for (int k = 0; k < size_array; k ++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == array[k])
                    count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
    }
}



Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0] * size[1]];
Console.WriteLine("Начальная матрица: ");
int size_array = 0;
InputMatrix(matrix, array, ref size_array);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
MatrixCounter(array,matrix,size_array);