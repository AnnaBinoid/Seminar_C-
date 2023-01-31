/*
Задача 53: 
Задайте двумерный массив. 
Напишите программу,которая поменяет местами первую и последнюю строку
массива.
*/

int matrixRows = 6;
int matrixColumns = 4;
int minValue = 1;
int maxValue = 11;

int[,] matrixForChange = CreateMatrix(matrixRows, matrixColumns, minValue, maxValue);
PrintArray(matrixForChange);
ChangeFirstAndLastRows(matrixForChange);
Console.WriteLine(String.Empty);
PrintArray(matrixForChange);


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return (matrix);
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine($" ]");
    }
}

void ChangeFirstAndLastRows(int[,] matrix)
{
    int temp = 0;
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[firstRow, j];
        matrix[firstRow, j] = matrix[lastRow, j];
        matrix[lastRow, j] = temp;

    }
}
