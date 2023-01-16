/*
Задача 31: Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму
отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

int[] CreateArrayRndInt(int size, int min, int max) // в скобках - сигнатура метода
{
    int[] arr = new int[size];
    Random rnd = new Random(); // var rnd = new Random(), это неявная типизация
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

/*int GetSumPositiveElem (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}  
   
int GetSumNegativeElem (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}*/

int[] TwoSumPosNeg(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        else if (arr[i] < 0) sumNeg += arr[i];
    }

    return new[]{sumNeg, sumPos};
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
/*
//1 способ
int sumPositive = GetSumPositiveElem(array);
int sumNegative = GetSumNegativeElem(array);

Console.WriteLine ($"The summ of positive elements is {sumPositive}.");
Console.WriteLine ($"The summ of negative elements is {sumNegative}.");*/

int[] twoSumPosNeg = TwoSumPosNeg(array);
Console.WriteLine($"The summ of positive elements is {array[0]}.");
Console.WriteLine ($"The summ of negative elements is {array[1]}.");

/*ПРОВЕРИТЬ СПОСОБ 2
int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        else if (arr[i] < 0) sumNeg += arr[i];
    }

    return new int[]{sumPos, sumNeg};
}
*/