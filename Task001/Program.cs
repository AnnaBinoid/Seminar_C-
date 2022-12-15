//Напишшите программу, которая
//На вход принмает число и
//2. Выдает его квадрат (число, умноженное на себя).

Console.Write("Write the number, please: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

Console.WriteLine($"Good question! The square of {number} is: {square}!");