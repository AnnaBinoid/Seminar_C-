/* 63. Задайте значение N.
Напишите программу, которая выведет все натуральные числа от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
*/

/*65. Задайте M и N.
Напишите программу, которая выведет все натуральные числа от M до N.*/

Console.WriteLine ("Enter the natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(n);

/*void NaturalNumbers (int number)   //1 2 3 4 5
{
    if (number == 0) return;
    NaturalNumbers (number - 1);
    Console.Write($"{number} ");

}*/

void NaturalNumbers (int number)   //5 4 2 3 1
{
    if (number == 0) return;
    Console.Write($"{number} ");
    NaturalNumbers (number - 1);
}