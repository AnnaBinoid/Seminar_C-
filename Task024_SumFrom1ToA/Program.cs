/*Задача 24: Напишите программу, которая
принимает на вход число (А) и 
выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.WriteLine("Please, enter your natural number: ");
int number = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());       //принимает только строку //Convert.toInt32(Console.ReadLine);
int summ = Summ(number);
Console.WriteLine($"The sum of the numbers from 1 to {number} is {summ}");

int Summ (int digit)
{
    int count = 1;
    int sum = 0;

    while (count <= digit)
    {
        sum = sum + count;
        count++;
    }
    return sum;
}
