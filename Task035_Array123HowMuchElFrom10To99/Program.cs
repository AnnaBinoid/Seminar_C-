/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/


int[] CreateArray (int size)
{
    int[] array =  new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (-100, 200);
    }
    return array;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
        Console.Write("]");
}

int NumberElements (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] < 100) && (array[i] > 9)) count++;
    }
    return count;
}


int[] myArray = CreateArray(123);
PrintArray (myArray);
int myCount = NumberElements(myArray);
Console.WriteLine();
Console.WriteLine($"In this array number of elements from 10 to 99 is {myCount}.");