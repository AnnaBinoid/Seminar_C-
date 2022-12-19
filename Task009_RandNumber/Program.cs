/* 
Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

int randNumber = new Random().Next(10, 100);
Console.WriteLine ($"New random integer is {randNumber}!");

int ten = randNumber / 10;
int smallNumber = randNumber % 10;

/*if (ten >= smallNumber)
{
    Console.WriteLine(ten);
}
else Console.WriteLine($"Max number from {randNumber} is {smallNumber}");*/

int result = ten > smallNumber ? ten : smallNumber;
Console.Write($"Max number from {randNumber} is {result}!");