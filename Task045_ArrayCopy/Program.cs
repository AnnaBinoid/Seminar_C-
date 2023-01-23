/*
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/

int size = 5;
int[] array1 = CreateArray(size);
PrintArray(array1);
int[] arraySecond = CopyArray(array1);
PrintArray(arraySecond);

/*Проверка
Console.WriteLine(String.Empty);
array1[0] = 3;
arraySecond[0] = 5;
PrintArray(array1);
PrintArray(arraySecond);*/

int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine(arr[arr.Length - 1]);
    }
    Console.WriteLine(String.Empty);
}

int[] CopyArray (int[] arr2)
{
    int[] array2 = new int[arr2.Length];
    for (int i = 0; i < arr2.Length; i++)
    {
        array2[i] = arr2[i];
    }
    return array2;
}