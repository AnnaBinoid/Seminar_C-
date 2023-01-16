/*Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/


int[] CreateArray (int size)
{
    int[] array =  new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (-100, 101);
    }
    return array;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}

void ChangeSign (int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] myArray = CreateArray(10);
PrintArray(myArray);
Console.WriteLine();
ChangeSign(myArray);
PrintArray(myArray);

