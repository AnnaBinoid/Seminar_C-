/* 
Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

/*int randNumber = new Random().Next(10, 100);
Console.WriteLine ($"New random integer is {randNumber}!");*/

//int ten = randNumber / 10;
//int smallNumber = randNumber % 10;


/*ПЕРЕДЕЛАТЬ ЗАДАЧУ!!!!!

int MaxDigit = MaxDigit(45);
Console.WriteLine ($"Max number from {randNumber} is {result}!");

int MaxDigit(int number)
{
    int ten = randNumber / 10;
    int smallNumber = randNumber % 10;

    int result = ten > smallNumber ? ten : smallNumber;
    return result;
}

int MaxDigit = MaxDigit(randNumber);
Console.WriteLine ($"Max number from {randNumber} is {result}!");*/

/*Variant 1

if (ten >= smallNumber)
{
    Console.WriteLine(ten);
}
else Console.WriteLine($"Max number from {randNumber} is {smallNumber}");*/

/*Variant 2

int result = ten > smallNumber ? ten : smallNumber;
Console.Write($"Max number from {randNumber} is {result}!");*/


/* ОТ АНДРЕЯ*/

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
