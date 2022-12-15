Console.Write("Write the number, please: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Write the number, please: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int squareOne = numberOne * numberOne;

Console.WriteLine(numberOne);
Console.WriteLine(numberTwo);

if (numberTwo == squareOne)
{
    Console.WriteLine("It's a sqare!");
}
else Console.WriteLine("It's not a sqare!");