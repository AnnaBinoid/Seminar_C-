/*12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

/*int firstNumber = new Random().Next(10,100);
int secondNumber = new Random().Next(10, 100);*/

Console.WriteLine("Enter first name!");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second name!");
int secondNumber = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"First random integer is {firstNumber}.");
Console.WriteLine($"Second random integer is {secondNumber}.");
Console.WriteLine (Multiple(firstNumber, secondNumber));

string Multiple (int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        return "Firs smaller, then second.";
    }
    else
    return firstNum % secondNum == 0 ? "кратно" : $"не кратно, остаток {firstNum % secondNum}";

}