/*
Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Please, enter the number of quarter from 1 to for 4: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of quarter is: {number}.");

string result = Quarter(number);
Console.WriteLine($"For number {number} range of values is {result}.");

string Quarter (int num)
{
    if  (num == 1) return "x > 0 ; y > 0";
    if  (num == 2) return "x < 0 ; y > 0";
    if  (num == 3) return "x < 0 ; y < 0";
    if  (num == 4) return "x > 0 ; y < 0";
    return "Out of range";
}


