/*
/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/


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
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
        Console.Write("]");
}

bool IsNumberInArray (int[] arr, int ourNumber)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == ourNumber) return true;
    }

    return false;
}


int[] myArray = CreateArray(10);
PrintArray(myArray);
Console.WriteLine();

Console.Write("Enter your number, please : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

bool owrAnser = IsNumberInArray(myArray, userNumber);
if (owrAnser == true) Console.WriteLine (" -> yes");
else Console.WriteLine (" -> no");