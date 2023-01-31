/*
 На вход А и В. 
 Возводит А в степень В рекурсией.

 А = 3, В = 5 -> 243
 А = 2, В = 3 -> 8
 */

Console.Write ("Enter the natural number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter the natural number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    Console.WriteLine (ADegreeB(a, b));
}

else Console.WriteLine ("Please, enter positive b.");

int ADegreeB (int one, int two)
{
    if (two == 0) return 1;
    
    else return (one * ADegreeB (one, two - 1));
}
