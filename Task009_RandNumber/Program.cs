/* 
Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

int randNumber = new Random().Next(10, 100);
Console.WriteLine ($"Our random integer is {randNumber}");
int ourDigit = MaxDigit(randNumber);
Console.WriteLine($"Max digit from random integer {randNumber} is {ourDigit}!");

int MaxDigit(int randNum)
{
    int tens = randNum / 10;
    int ones = randNum % 10;

    return tens > ones ? tens : ones;
}

/* Для частных случаев в параметрах на вход можно использовать конкретные данные, а не переменные.

int firstOurDigit = MaxDigit(15);
int secondOurDigit = MaxDigit(24);

Console.WriteLine ($"Max digit is {firstOurDigit}!");
Console.WriteLine ($"Max digit is {secondOurDigit}!");

int MaxDigit(int ourDigit)
{
    int tens = ourDigit / 10;
    int ones = ourDigit % 10;

    return tens > ones ? tens : ones;*/