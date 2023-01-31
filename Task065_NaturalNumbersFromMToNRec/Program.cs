/*
/*65. Задайте M и N.
Напишите программу, которая выведет все натуральные числа от M до N.
M = 1, N = 5,   1, 2, 3, 4, 5
N = 5, N = 1,   1, 2, 3, 4, 5

*/


Console.Write ("Enter the natural number: ");
int m = Convert.ToInt32(Console.ReadLine());   //1
Console.Write ("Enter the natural number: ");
int n = Convert.ToInt32(Console.ReadLine());   //5

RecFroMtoN(m, n);


void RecFroMtoN (int one, int two)
{
    if (one == two) Console.Write($"{one} ");
    else if (one < two)
    {
        Console.Write($"{two} ");
        RecFroMtoN(one + 1 , two);
    }
    else if (one > two)
    {
        Console.Write ($"{one} ");
        RecFroMtoN(one -1, two);
    }
    
}

