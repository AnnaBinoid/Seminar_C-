/*
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N
*/

Console.WriteLine("Enter digit N : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("It's not natural digit. Try again.");
}
else SquareTable(number);

void SquareTable(int num)
{
    for (int i = 1 ; i <= num ; i++)
    {
        Console.WriteLine($"{i}  |  {Math.Pow(i, 2)}");
    }
}


