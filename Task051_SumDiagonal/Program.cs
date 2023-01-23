/*
Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("]");
    }
}

/*int FindSumOfDiagonalElements(int[,] matrix)
{
    int sum = 0;
    if (matrix.GetLength(0) >= matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, i];
        }
    }
    else 
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }
    }
    return sum;
}
*/

int FindSumOfDiagonalElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}


int[,] array2D = CreateMatrixRndInt(4, 6, 1, 10);
PrintMatrix(array2D);
int sumMatrix = FindSumOfDiagonalElements(array2D);
Console.WriteLine(String.Empty);
Console.WriteLine($"The sum of diagonal elements is: {sumMatrix}.");


/*
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int FindSumDiagonalIndex(int[,] matrix)
{
    int size = matrix.GetLength(0);
    if (size > matrix.GetLength(1)) size = matrix.GetLength(1);
    int sum = 0;
    for (int j = 0; j < size; j++)
    {
        sum += matrix[j, j];
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int sum = FindSumDiagonalIndex(array2D);
Console.WriteLine(sum);
*/