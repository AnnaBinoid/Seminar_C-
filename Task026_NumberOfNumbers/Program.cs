/*Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> */

Console.WriteLine("Please, enter your natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfNumbers = NumberOfNumbers(number);
Console.WriteLine(numberOfNumbers);


int NumberOfNumbers(int digit)
{
    //int length = digit.Length;
    int count = 0;

    while (digit != 0)
    {
        digit = digit/10;
        count = count + 1;
    }
    return count;
}