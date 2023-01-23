/*
Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  //0, 1 - индексы rows, columns соответственно
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  //по строкам, их будет 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //по столбцам, их будет 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);  // если нужно сначала по столбцам, потом по строкам -меняем местами [j, i] или в циклах фор поменять гетленгт j (1) в первом, i (0) во втором.
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 99);
PrintMatrix(array2D);