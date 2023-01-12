/*Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int[] CreateArray (int count)
{
    return new int[count];
}

void Fill (int[] newArray)
{
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    newArray[i] =  rnd.Next(2); //new Random().Next(0,2);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]} ");
}


int count = 8;
int[] arr = CreateArray(count);
Fill(arr);
PrintArray(arr);