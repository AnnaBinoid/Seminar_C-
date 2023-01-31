/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
*/

int[,] array2d = CreateMatrix(4, 4, -5, 40);
PrintMatrix(array2d);
int[] indexMinVal = IndexMinVal(array2d);
PrintArray(array2d);

RemoveRowColumnCross(array2d, indexMinVal(0), indexMixVal(1));


int[,] RemoveRowColumnCross (int[,] matrix, int removeRow, int removeColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)- 1];
    int m = 0;
    int n = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == removeRow) m ++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i == removeColumn) n++;

            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexRow = 0;
    int indexCOlumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) 
            {
                min = matrix[i, j];
                indexRow = i;
                indexCOlumn = j;
            }
        }
    }
    return new int[i, j] {indexRow, indexCOlumn, min};
}


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
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
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

/*
int[,] RemoveRowColumnCrossed(int[,] matrix, int removeRow, int removeColumn){    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];    int m = 0;    int n = 0;    for (int i = 0; i < newMatrix.GetLength(0); i++)    {        if (i == removeRow) m++;        for (int j = 0; j < newMatrix.GetLength(1); j++)        {            if (j == removeColumn) n++;            newMatrix[i,j] = matrix[m,n];            n++;        }        m++;        n = 0;    }    return newMatrix;}int[] IndexMinVal(int[,] matrix){    int min = matrix[0, 0];    int indexRow = 0;    int indexColumn = 0;    for (int i = 0; i < matrix.GetLength(0); i++)    {        for (int j = 0; j < matrix.GetLength(1); j++)        {            if (matrix[i, j] < min)            {                min = matrix[i, j];                indexRow = i;                indexColumn = j;            }        }    }    return new int[
*/