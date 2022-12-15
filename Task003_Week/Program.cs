//3. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Write the number from 1 to 7, please: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 7 && number > 0)
{
    if (number == 1)
    {
        Console.WriteLine("It's Monday!");
    }
    if (number == 2)
    {
        Console.WriteLine("It's Tuesday!");
    }
    if (number == 3)
    {
        Console.WriteLine("It's Wednesday!");
    }
    if (number == 4)
    {
        Console.WriteLine("It's Thursday!");
    }
    if (number == 5)
    {
        Console.WriteLine("It's Friday!");
    }
    if (number == 6)
    {
        Console.WriteLine("It's Saturday!");
    }
    if (number == 7)
    {
        Console.WriteLine("It's Sunday!");
    }
}
else
{ Console.WriteLine("Please, read conditions carefully! Next time write the number from 1 to 7."); }