/*Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Please, enter your natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int product = ProductNumber(number);
Console.WriteLine($"Factorial of {number} is {product}");


int ProductNumber (int digit)
{
    int count = 1;

    for (int i = 1; i <= digit; i++ )
    {
        count = count * i;
    }
    
    return count;
}

